using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtifactsApp.Repos.Contracts
{
    public interface IArtifactsRepository
    {
        Task<int> GetGenusByName(string name);
        Task<int> GetSpeciesByName(string name);
    }
}
