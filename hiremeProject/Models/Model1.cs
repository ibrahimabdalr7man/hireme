using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace hiremeProject.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<Post>()
                .Property(e => e.details)
                .IsUnicode(false);

            modelBuilder.Entity<Post>()
                .Property(e => e.passwordPost)
                .IsUnicode(false);
        }
    }
}
