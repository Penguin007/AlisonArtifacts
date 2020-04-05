using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArtifactsApp.Models.ViewModels
{
    public class ArtifactCreateViewModel : Artifact
    {
        [Display(Name ="New Species")]
        public string SpeciesText { get; set; }
    }
}
