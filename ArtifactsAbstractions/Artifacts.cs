using System;

namespace ArtifactsAbstractions
{
    public class Artifacts
    {
        public Artifacts()
        {

        }

        private int pk { get; }

        public int phylumId { get; set; }

        public int classId { get; set; }

        public int genusId { get; set; }

        public int speciedId { get; set; }

        public string description { get; set; }


    }
}
