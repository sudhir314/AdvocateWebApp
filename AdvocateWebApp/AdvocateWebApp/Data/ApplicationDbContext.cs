using AdvocateWebApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<AdvocateWebApp.Data.ApplicationUser>(options)
{
     public DbSet<PracticeAreaService> PracticeAreaServices { get; set; }
}
