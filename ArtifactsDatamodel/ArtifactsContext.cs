using ArtifactsDatamodel.Models;
using Microsoft.EntityFrameworkCore;

namespace ArtifactsData
{
    public class ArtifactsContext : DbContext
    {
        public ArtifactsContext() : base() { }
        public virtual DbSet<Artifact> Artifacts { get; set; }

        public virtual DbSet<Class> Classes { get; set; }

        public virtual DbSet<Class> Families { get; set; }

        public virtual DbSet<Genus> Genera { get; set; }

        public virtual DbSet<Kingdom> Kingdoms { get; set; }

        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<Owner> Owners { get; set; }

        public virtual DbSet<Phylum> Phyla { get; set; }

        public virtual DbSet<Source> Sources { get; set; }

        public virtual DbSet<Species> Species { get; set; }
    }
}
