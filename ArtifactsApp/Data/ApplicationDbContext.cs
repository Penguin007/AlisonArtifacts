using ArtifactsApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ArtifactsApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual Microsoft.EntityFrameworkCore.DbSet<Artifact> Artifact { get; set; }

        public virtual DbSet<Class> Class { get; set; }

        public virtual DbSet<Family> Family { get; set; }

        public virtual DbSet<Genus> Genus { get; set; }

        public virtual DbSet<Kingdom> Kingdom { get; set; }

        public virtual DbSet<Order> Order { get; set; }

        public virtual DbSet<Owner> Owner { get; set; }

        public virtual DbSet<Phylum> Phylum { get; set; }

        public virtual DbSet<Source> Source { get; set; }

        public virtual DbSet<Species> Species { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Species>()
        //        .HasOptional(s => s.Phyla)
        //        .Wi
        //        .WillCascadeOnDelete(false);
        //}
    }
}
