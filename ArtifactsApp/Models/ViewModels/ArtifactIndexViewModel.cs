using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArtifactsApp.Models.ViewModels
{
    public class ArtifactIndexViewModel : Artifact
    {
        [Display(Name = "Phylum")]
        public string PhylumText { get; set; }

        [Display(Name = "Class")]
        public string ClassText { get; set; }

        [Display(Name = "Order")]
        public string OrderText { get; set; }

        [Display(Name = "Family")]
        public string FamilyText { get; set; }

        [Display(Name = "Genus")]
        public string GenusText { get; set; }

        [Display(Name = "Species")]
        public string SpeciesText { get; set; }
    }
}
