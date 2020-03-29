using ArtifactsApp.Models.Contracts;

namespace ArtifactsApp.Models
{
    public class Order : IEntity
    { 
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
