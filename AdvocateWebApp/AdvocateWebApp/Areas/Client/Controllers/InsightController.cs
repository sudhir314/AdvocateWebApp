using AdvocateWebApp.DataAccess.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdvocateWebApp.Areas.Client.Controllers
{
    [Area("Client")]
    [Route("Client/[controller]/[action]")]
    public class InsightController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InsightController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Supports: /Client/Insight/Insight?slug=... AND /Client/Insight/Insight/{slug?}
        [HttpGet]
        [Route("/Client/Insight/Insight/{slug?}")]
        public async Task<IActionResult> Insight(string slug)
        {
            if (string.IsNullOrWhiteSpace(slug))
            {
                // Default fallback to the first active article
                var defaultArticle = await _context.InsightArticles
                    .AsNoTracking()
                    .Where(a => a.IsActive)
                    .OrderBy(a => a.DisplayOrder)
                    .FirstOrDefaultAsync();

                if (defaultArticle == null)
                {
                    return NotFound();
                }

                return RedirectToAction(nameof(Insight), new { slug = defaultArticle.Slug });
            }

            // Fetch the requested article using AsNoTracking for peak performance
            var article = await _context.InsightArticles
                .AsNoTracking()
                .FirstOrDefaultAsync(a => a.Slug == slug && a.IsActive);

            if (article == null)
            {
                return NotFound();
            }

            // Populate ViewBag.AllArticles for the left sidebar navigation menu
            ViewBag.AllArticles = await _context.InsightArticles
                .AsNoTracking()
                .Where(a => a.IsActive)
                .OrderBy(a => a.CategoryName)
                .ThenBy(a => a.DisplayOrder)
                .ToListAsync();

            return View(article);
        }
    }
}