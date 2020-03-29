using ArtifactsApp.Models.Contracts;

namespace ArtifactsApp.Models
{
    public class Class : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
