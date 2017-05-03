using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Boats.Models
{
    public class BoatsDbContext : IdentityDbContext<AssociateUser>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BoatStore;integrated security=True");
        }
        public BoatsDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sale>()
               .HasKey(t => new { t.AssociateBoatId });

            modelBuilder.Entity<Sale>()
                .HasOne(pt => pt.Boat)
                .WithMany(p => p.Sales)
                .HasForeignKey(pt => pt.BoatId);

            modelBuilder.Entity<Sale>()
               .HasOne(pt => pt.AssociateUser)
               .WithMany(p => p.Sales)
               .HasForeignKey(pt => pt.AssociateId);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Boat> Boats { get; set; }
        public DbSet<Sale> Sales { get; set; }
      

    }


}
