using System;
using System.Collections.Generic;
using System.Text;

namespace ArtifactsDatamodel.Models
{
    public class Owner
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public string Organization { get; set; }
    }
}
