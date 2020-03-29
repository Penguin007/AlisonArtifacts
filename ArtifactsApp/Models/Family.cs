using ArtifactsApp.Models.Contracts;

namespace ArtifactsApp.Models
{
    public class Family : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
