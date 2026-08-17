
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdvocateWebApp.Areas.Client.Controllers
{
    [Area("Client")]
    [Route("Client/[controller]/[action]")]
    public class NavController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NavController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Support both: /Client/Nav/PracticeArea?slug=writ-petitions AND /Client/Nav/PracticeArea/writ-petitions
        [HttpGet]
        [Route("/Client/Nav/PracticeArea/{slug?}")]
        public async Task<IActionResult> PracticeArea(string slug)
        {
            if (string.IsNullOrWhiteSpace(slug))
            {
                // Default fallback slug agar URL me slug na bheja gaya ho
                slug = "anticipatory-bail";
            }

            // AsNoTracking() se read performance improve hoti hai
            var service = await _context.PracticeAreaServices
                .AsNoTracking()
                .FirstOrDefaultAsync(s => s.Slug == slug && s.IsActive);

            if (service == null)
            {
                // Note: Agar database me slug ka data insert nahi hua hai tab hi 404 aayega
                return NotFound();
            }

            // Sidebar navigation ke liye saare active services fetch kar rahe hain
            ViewBag.AllServices = await _context.PracticeAreaServices
                .AsNoTracking()
                .Where(s => s.IsActive)
                .OrderBy(s => s.CategoryName)
                .ThenBy(s => s.DisplayOrder)
                .ToListAsync();

            return View(service);
        }
    }
}