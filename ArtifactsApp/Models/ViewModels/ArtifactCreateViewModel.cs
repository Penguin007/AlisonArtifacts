using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArtifactsApp.Models.ViewModels
{
    public class ArtifactCreateViewModel : Artifact
    {
        [Display(Name = "Kingdom")]
        [Required]
        public string KingdomText { get; set; }

        [Display(Name = "Phylum")]
        [Required]
        public string PhylumText { get; set; }

        [Display(Name = "Class")]
        [Required]
        public string ClassText { get; set; }

        [Display(Name = "Order")]
        public string OrderText { get; set; }

        [Display(Name = "Family")]
        [Required]
        public string FamilyText { get; set; }

        [Display(Name = "Genus")]
        [Required]
        public string GenusText { get; set; }

        [Display(Name = "Species")]
        public string SpeciesText { get; set; }
    }
}
