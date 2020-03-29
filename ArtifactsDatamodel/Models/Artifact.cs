using ArtifactsDatamodel.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArtifactsData
{
    public class Artifact
    {
        public int Id { get; }

        [Required]
        public string CommonNameOne { get; set; }

        public string CommonNameTwo { get; set; }

        public string CommonNameThree { get; set; }

        public string CommonNameFour { get; set; }

        public string CommonNameFive { get; set; }

        [Required]
        public string Description { get; set; }

        public int ClassId { get; set; }

        public int FamilyId { get; set; }

        public int GenusId { get; set;}

        public int KingdomId { get; set; }

        public int PhylumId { get; set; }

        public int SpeciesId { get; set; }

        public int SourceId { get; set; }

        public int OwnerId { get; set; }

        [Required]
        public int Quantity { get; set; }

        public Decimal ApproxValue { get; set; }

        public DateTime? AquiredDate { get; set; }

        public bool IsDonated { get; set; }

        public string DonatedBy { get; set; }

        [Required]
        public bool IsExtinct { get; set; }

        public DateTime? FirstDiscoveredDate { get; set; }

        public DateTime? LastDiscoveredDate { get; set; }

        [ForeignKey("ClassID")]
        public virtual Class Class { get; set; }

        [ForeignKey("FamilyId")]
        public virtual Family Family { get; set; }

        [ForeignKey("GenusId")]
        public virtual Genus Genus { get; set; }

        [ForeignKey("KingdomId")]
        public virtual Kingdom Kingdom { get; set; }

        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }

        [ForeignKey("PhylumId")]
        public virtual Phylum Phylum { get; set; }

        [ForeignKey("SpeciesId")]
        public virtual Species Species { get; set; }

        [ForeignKey("OwnerId")]
        public virtual Owner Owner { get; set; }

        [ForeignKey("SourceId")]
        public virtual Source Source { get; set; }
    }
}
