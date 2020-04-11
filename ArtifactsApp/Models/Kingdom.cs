using ArtifactsApp.Models.Contracts;
using System.Collections.Generic;

namespace ArtifactsApp.Models
{
    public class Kingdom : IEntity
    {
        public Kingdom()
        {
            Phyla = new List<Phylum>();
            Classes = new List<Class>();
            Orders = new List<Order>();
            Familes = new List<Family>();
            Genuses = new List<Genus>();
            Species = new List<Species>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Phylum> Phyla { get; set; }

        public ICollection<Class> Classes { get; set; }

        public ICollection<Order> Orders { get; set; }

        public ICollection<Family> Familes { get; set; }

        public ICollection<Genus> Genuses { get; set; }

        public ICollection<Species> Species { get; set; }
    }
}
