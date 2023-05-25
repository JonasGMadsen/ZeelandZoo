using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ZeelandZoo.Models;

namespace ZeelandZoo.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ZeelandZoo.Models.Events>? Events { get; set; }
        public DbSet<ZeelandZoo.Models.News>? News { get; set; }

    }


}