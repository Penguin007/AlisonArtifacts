using ArtifactsApp.Models.Contracts;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArtifactsApp.Models
{
    public class Class : IEntity
    {
        public Class()
        {
            Orders = new List<Order>();
            Familes = new List<Family>();
            Genuses = new List<Genus>();
            Species = new List<Species>();
        }

        public int Id { get; set; }
        
        public string Name { get; set; }

        public int? PhylumId { get; set; }
        
        public int? KingdomId { get; set; }

        [ForeignKey("PhylumId")]
        public virtual Phylum Phylum { get; set; }
        
        [ForeignKey("KingdomId")]
        public virtual Kingdom Kingdom { get; set; }

        public ICollection<Order> Orders { get; set; }

        public ICollection<Family> Familes { get; set; }

        public ICollection<Genus> Genuses { get; set; }

        public ICollection<Species> Species { get; set; }
    }
}
