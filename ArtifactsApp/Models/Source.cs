using ArtifactsApp.Models.Contracts;
using System.ComponentModel.DataAnnotations;

namespace ArtifactsApp.Models
{
    /// <summary>
    /// Where the artifact was acquired
    /// </summary>
    public class Source : IEntity
    {
        public int Id { get; set; }

        [Display(Name ="Business Name")]
        [Required]
        public string BusinessName { get; set; }

        [Display(Name ="Address 1")]
        [Required]
        public string Addr1 { get; set; }

        [Display(Name = "Address 2")]
        public string Addr2 { get; set; }

        [Required]
        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public string Country { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        [Display(Name ="Website")]
        public string SiteUrl { get; set; }

        public string Hours { get; set; }

        [Display(Name ="Commercial?")]
        public bool IsCommercial { get; set; }

        public string Notes { get; set; }
    }
}
