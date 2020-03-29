using ArtifactsApp.Data;
using ArtifactsApp.Models;

namespace ArtifactsApp.Repos
{
    public class ArtifactsRepository : GenericRepository<Artifact, ApplicationDbContext>
    {
        public ArtifactsRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
