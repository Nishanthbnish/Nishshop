using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace nishshop.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<brand> brands { get; set; }
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<product> products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<brand>()
                .Property(e => e.brand1)
                .IsUnicode(false);

            modelBuilder.Entity<brand>()
                .HasMany(e => e.products)
                .WithOptional(e => e.brand)
                .HasForeignKey(e => e.brand_id);

            modelBuilder.Entity<category>()
                .Property(e => e.category1)
                .IsUnicode(false);

            modelBuilder.Entity<category>()
                .HasMany(e => e.products)
                .WithOptional(e => e.category)
                .HasForeignKey(e => e.cat_id);

            modelBuilder.Entity<product>()
                .Property(e => e.prodname)
                .IsUnicode(false);
        }
    }
}
