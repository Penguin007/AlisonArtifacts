using ArtifactsApp.Data;
using ArtifactsApp.Models;
using ArtifactsApp.Repos.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
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

        public async Task<int?> KingdomExists(string name)
        {
            var kingdom = await _context.Kingdom.FirstOrDefaultAsync(e => e.Name.ToUpper() == name.ToUpper().Trim());
            return kingdom?.Id;
        }

        public async Task<int?> PhylumExists(string name)
        {
            var phyllum = await _context.Phylum.FirstOrDefaultAsync(e => e.Name.ToUpper() == name.ToUpper().Trim());
            return phyllum?.Id;
        }

        public async Task<int?> ClassExists(string name)
        {
            var classVar = await _context.Class.FirstOrDefaultAsync(e => e.Name.ToUpper() == name.ToUpper().Trim());
            return classVar?.Id;
        }

        public async Task<int?> OrderExists(string name)
        {
            var orderVar = await _context.Order.FirstOrDefaultAsync(e => e.Name.ToUpper() == name.ToUpper().Trim());
            return orderVar?.Id;
        }

        public async Task<int?> FamilyExists(string name)
        {
            var family = await _context.Family.FirstOrDefaultAsync(e => e.Name.ToUpper() == name.ToUpper().Trim());
            return family?.Id;
        }

        public async Task<int?> GenusExists(string name)
        {
            var genus = await _context.Genus.FirstOrDefaultAsync(e => e.Name.ToUpper() == name.ToUpper().Trim());
            return genus?.Id;
        }

        public async Task<int?> SpeciesExists(string name)
        {
            var species = await _context.Species.FirstOrDefaultAsync(e => e.Name.ToUpper() == name.ToUpper().Trim());
            return species?.Id;
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
