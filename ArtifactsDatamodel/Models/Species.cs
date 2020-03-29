using System.ComponentModel.DataAnnotations;

namespace ArtifactsData
{
    public class Species
    {
        public int Id { get; set; }

        public int GenusId { get; set; }

        public string Name { get; set; }

        public virtual Genus Genus { get; set;}

    }
}
