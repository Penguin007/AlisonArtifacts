using System;

namespace ArtifactsData
{
    public class Artifact
    {

        private int Id { get; }

        public string Description { get; set; }

        public int ClassId { get; set; }

        public int FamilyId { get; set; }

        public int GenusId { get; set;}

        public int KingdomId { get; set; }

        public int OrderId { get; set; }

        public int PhylumId { get; set; }

        public int SpeciesId { get; set; }

        public virtual Class Class { get; set; }

        public virtual Family Family { get; set; }

        public virtual Genus Genus { get; set; }

        public virtual Kingdom Kingdom { get; set; }

        public virtual Order Order { get; set; }

        public virtual Phylum Phylum { get; set; }

        public virtual Species Species { get; set; }


    }
}
