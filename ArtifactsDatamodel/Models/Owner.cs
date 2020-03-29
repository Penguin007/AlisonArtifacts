using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ArtifactsDatamodel.Models
{
    /// <summary>
    /// The owner of the artifact
    /// </summary>
    public class Owner
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public string Organization { get; set; }
    }
}
