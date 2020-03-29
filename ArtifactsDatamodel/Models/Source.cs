using System.ComponentModel.DataAnnotations;

namespace ArtifactsDatamodel.Models
{
    /// <summary>
    /// Where the artifact was acquired
    /// </summary>
    public class Source
    {
        public int Id { get; set; }

        public string BusinessName { get; set; }

        public string Addr1 { get; set; }

        public string Addr2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public string Country { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string SiteUrl { get; set; }

        public string Hours { get; set; }

        public bool IsCommercial { get; set; }
    }
}
