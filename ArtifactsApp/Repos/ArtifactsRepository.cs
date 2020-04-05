using ArtifactsApp.Data;
using ArtifactsApp.Models;
using ArtifactsApp.Repos.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace ArtifactsApp.Repos
{
    public class ArtifactsRepository : GenericRepository<Artifact, ApplicationDbContext>, IArtifactsRepository
    {
        private readonly ApplicationDbContext _context;
        public ArtifactsRepository(ApplicationDbContext context) : base(context)
        {
            this._context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<int> GetGenusByName(string name)
        {
            var genus = await _context.Genus.FirstOrDefaultAsync(genus => genus.Name == name);
            if (genus != null)
            {
                return genus.Id;
            }
            else
            {
                return -1;
            }
        }

        public async Task<int> GetSpeciesByName(string name)
        {
            var species = await _context.Species.FirstOrDefaultAsync(species => species.Name == name);
            if (species != null)
            {
                return species.Id;
            }
            else
            {
                return -1;
            }
        }
    }
}
