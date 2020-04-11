using ArtifactsApp.Models.Contracts;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArtifactsApp.Models
{
    public class Family : IEntity
    {
        public Family()
        {
            Genuses = new List<Genus>();
            Species = new List<Species>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int? OrderId { get; set; }

        public int? ClassId { get; set; }

        public int? PhylumId { get; set; }

        public int? KingdomId { get; set; }

        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }

        [ForeignKey("ClassId")]
        public virtual Class Class { get; set; }

        [ForeignKey("PhylumId")]
        public virtual Phylum Phylum { get; set; }

        [ForeignKey("KingdomId")]
        public virtual Kingdom Kingdom { get; set; }

        public ICollection<Genus> Genuses { get; set; }

        public ICollection<Species> Species { get; set; }
    }
}
