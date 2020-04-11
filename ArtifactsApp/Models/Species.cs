using ArtifactsApp.Models.Contracts;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArtifactsApp.Models
{
    public class Species : IEntity
    {
        public int Id { get; set; }

        public int GenusId { get; set; }

        public string Name { get; set; }

        public int? FamilyId { get; set; }

        public int? OrderId { get; set; }

        public int? ClassId { get; set; }

        public int? PhylumId { get; set; }

        public int? KingdomId { get; set; }

        [ForeignKey("GenusId")]
        public virtual Genus Genus { get; set;}

        [ForeignKey("FamilyId")]
        public virtual Family Family { get; set; }        

        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }        

        [ForeignKey("ClassId")]
        public virtual Class Class { get; set; }        

        [ForeignKey("PhylumId")]
        public virtual Phylum Phylum { get; set; }
        
        [ForeignKey("KingdomId")]
        public virtual Kingdom Kingdom { get; set; }

    }
}
