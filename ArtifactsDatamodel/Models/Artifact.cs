using ArtifactsDatamodel.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArtifactsData
{
    public class Artifact
    {
        public int Id { get; set; }

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

        public int KingdomId { get; set; }

        public int PhylumId { get; set; }

        public int SpeciesId { get; set; }

        public int SourceId { get; set; }

        public int OwnerId { get; set; }

        [Required]
        public int Quantity { get; set; }

        public float ApproxValue { get; set; }

        public DateTime? AquiredDate { get; set; }

        public bool IsDonated { get; set; }

        public string DonatedBy { get; set; }

        [Required]
        public bool IsExtinct { get; set; }

        public DateTime? FirstDiscoveredDate { get; set; }

        public DateTime? LastDiscoveredDate { get; set; }

        public virtual Class Class { get; set; }

        public virtual Family Family { get; set; }

        public virtual Kingdom Kingdom { get; set; }

        public virtual Order Order { get; set; }

        public virtual Phylum Phylum { get; set; }

        public virtual Species Species { get; set; }

        public virtual Owner Owner { get; set; }

        public virtual Source Source { get; set; }
    }
}
