using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MensualidadGym.Models;

namespace MensualidadGym.Data
{
    public class MensualidadGymContext : IdentityDbContext<IdentityUser>
    {
        public MensualidadGymContext(DbContextOptions<MensualidadGymContext> options)
            : base(options)
        {
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<Plan> Plans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Plan>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)");
        }
    }
}
