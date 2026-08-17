using AdvocateWebApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AdvocateWebApp.DataAccess.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<PracticeAreaService> PracticeAreaServices { get; set; }

        public DbSet<InsightArticle> InsightArticles { get; set; }
    }
}