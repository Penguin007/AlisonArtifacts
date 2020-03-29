using ArtifactsApp.Models.Contracts;

namespace ArtifactsApp.Models
{
    public class Species : IEntity
    {
        public int Id { get; set; }

        public int GenusId { get; set; }

        public string Name { get; set; }

        public virtual Genus Genus { get; set;}

    }
}
