using ArtifactsApp.Models.Contracts;
using System;
using System.ComponentModel.DataAnnotations;

namespace ArtifactsApp.Models
{
    public class Artifact : IEntity
    {
        public int Id { get; set; }

        [Display(Name = "Common Name 1")]
        [Required]
        public string CommonNameOne { get; set; }

        [Display(Name = "Common Name 2")]
        public string CommonNameTwo { get; set; }

        [Display(Name = "Common Name 3")]
        public string CommonNameThree { get; set; }

        [Display(Name = "Common Name 4")]
        public string CommonNameFour { get; set; }

        [Display(Name = "Common Name 5")]
        public string CommonNameFive { get; set; }

        [Required]
        public string Description { get; set; }

        [Display(Name = "Class")]
        public int ClassId { get; set; }

        [Display(Name = "Family")]
        public int FamilyId { get; set; }

        [Display(Name = "Kingdom")]
        public int KingdomId { get; set; }

        [Display(Name = "Phylum")]
        public int PhylumId { get; set; }

        [Display(Name = "Species")]
        public int SpeciesId { get; set; }

        [Display(Name = "Source")]
        public int SourceId { get; set; }

        [Display(Name = "Owner")]
        public int OwnerId { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public int Quantity { get; set; }

        [Required]
        [Display(Name = "Approx. Value")]
        public float ApproxValue { get; set; }

        [Display(Name = "Date Acquired")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? AquiredDate { get; set; }

        [Display(Name = "Donated?")]
        public bool IsDonated { get; set; }

        [Display(Name = "Donated by")]
        public string DonatedBy { get; set; }

        [Required]
        [Display(Name = "Extinct?")]
        public bool IsExtinct { get; set; }

        [Display(Name ="First Discovered")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? FirstDiscoveredDate { get; set; }

        [Display(Name ="Last Discovered")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
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
