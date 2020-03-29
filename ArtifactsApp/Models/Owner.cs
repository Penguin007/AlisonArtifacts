using ArtifactsApp.Models.Contracts;

namespace ArtifactsApp.Models
{
    /// <summary>
    /// The owner of the artifact
    /// </summary>
    public class Owner : IEntity
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public string Organization { get; set; }
    }
}
