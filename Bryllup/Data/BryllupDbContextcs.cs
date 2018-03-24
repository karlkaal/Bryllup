using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bryllup.Data
{
    public class BryllupDbContext : DbContext
    {

        public virtual DbSet<Attendee> Attendee { get; set; }

        public BryllupDbContext(DbContextOptions<BryllupDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Attendee>(entity =>
            {
                entity.HasKey("UserName");
                entity.Property(p => p.UserName).HasMaxLength(100);
                entity.Property(p => p.Name1).HasMaxLength(100);
                entity.Property(p => p.Name2).HasMaxLength(100);
                entity.Property(p => p.Comment).HasMaxLength(4000);
                entity.Property(p => p.Phone).HasMaxLength(50);
            });

            base.OnModelCreating(builder);

           
        }
    }
}
