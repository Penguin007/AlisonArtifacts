using ArtifactsApp.Data;
using ArtifactsApp.Models;
using ArtifactsApp.Models.ViewModels;
using ArtifactsApp.Repos.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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

        public async Task<List<ArtifactIndexViewModel>> GetArtifactsAsync()
        {
            
            var artifactIndexList = await (from artifacts in _context.Artifact
                            join phylums in _context.Phylum on artifacts.PhylumId equals phylums.Id into phylumGroup 
                                           from p in phylumGroup.DefaultIfEmpty()
                            join classes in _context.Class on artifacts.ClassId equals classes.Id into classGroup 
                                           from c in classGroup.DefaultIfEmpty()
                            join orders in _context.Order on artifacts.OrderId equals orders.Id into orderGroup 
                                           from o in orderGroup.DefaultIfEmpty()
                            join families in _context.Family on artifacts.FamilyId equals families.Id into familyGroup 
                                           from f in familyGroup.DefaultIfEmpty()
                            join genuses in _context.Genus on artifacts.GenusId equals genuses.Id into genusGroup
                                from g in genusGroup.DefaultIfEmpty()
                            join species in _context.Species on artifacts.SpeciesId equals species.Id into speciesGroup 
                                           from s in speciesGroup.DefaultIfEmpty()
                            select new ArtifactIndexViewModel
                            {
                                Id = artifacts.Id,
                                CommonNameOne = artifacts.CommonNameOne,
                                PhylumText = (p.Name) ?? "",
                                ClassText = (c.Name) ?? "",
                                OrderText = (o.Name) ?? "",
                                FamilyText = (f.Name) ?? "",
                                GenusText = (g.Name) ?? "",
                                SpeciesText = (s.Name) ?? "",
                                Quantity = artifacts.Quantity,
                                ApproxValue = artifacts.ApproxValue,
                                AquiredDate = artifacts.AquiredDate,
                                Source = artifacts.Source,
                                Owner = artifacts.Owner
                            }).ToListAsync<ArtifactIndexViewModel>();

            return artifactIndexList;
            
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
