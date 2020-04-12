using ArtifactsApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtifactsApp.Repos.Contracts
{
    public interface IArtifactsRepository
    {
        Task<int?> KingdomExists(string name);
        Task<int?> PhylumExists(string name);
        Task<int?> ClassExists(string name);
        Task<int?> OrderExists(string name);
        Task<int?> FamilyExists(string name);
        Task<int?> GenusExists(string name);
        Task<int?> SpeciesExists(string name);

        Task<List<ArtifactIndexViewModel>> GetArtifactsAsync();

        Task<int> GetGenusByName(string name);
        Task<int> GetSpeciesByName(string name);
    }
}
