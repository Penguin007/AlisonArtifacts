using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ArtifactsApp.Data;
using ArtifactsApp.Models;
using Microsoft.AspNetCore.Authorization;
using ArtifactsApp.Models.ViewModels;
using ArtifactsApp.Repos.Contracts;
using ArtifactsApp.Repos;

namespace ArtifactsApp.Controllers
{
    public class ArtifactsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IArtifactsRepository _artifactRepository;

        public ArtifactsController(ApplicationDbContext context, IArtifactsRepository artifactRepository)
        {
            _context = context;
            _artifactRepository = artifactRepository;
        }

        // GET: Artifacts
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Artifact.Include(a => a.Class).Include(a => a.Family).Include(a => a.Kingdom).Include(a => a.Owner).Include(a => a.Phylum).Include(a => a.Source).Include(a => a.Species);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Artifacts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artifact = await _context.Artifact
                .Include(a => a.Class)
                .Include(a => a.Family)
                .Include(a => a.Kingdom)
                .Include(a => a.Owner)
                .Include(a => a.Phylum)
                .Include(a => a.Source)
                .Include(a => a.Species)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (artifact == null)
            {
                return NotFound();
            }

            return View(artifact);
        }

        // GET: Artifacts/Create
        [HttpGet]
        public IActionResult Create()
        {
            ViewData["ClassId"] = new SelectList(_context.Class, "Id", "Name");
            ViewData["FamilyId"] = new SelectList(_context.Family, "Id", "Id");
            ViewData["KingdomId"] = new SelectList(_context.Kingdom, "Id", "Id");
            ViewData["OwnerId"] = new SelectList(_context.Owner, "Id", "Id");
            ViewData["PhylumId"] = new SelectList(_context.Phylum, "Id", "Id");
            ViewData["SourceId"] = new SelectList(_context.Source, "Id", "BusinessName");
            ViewData["SpeciesId"] = new SelectList(_context.Species, "Id", "Id");
            return View();
        }

        // POST: Artifacts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CommonNameOne,CommonNameTwo,CommonNameThree,CommonNameFour,CommonNameFive,Description,ClassId,FamilyId,KingdomId,PhylumId,SpeciesId,SourceId,OwnerId,Quantity,ApproxValue,AquiredDate,IsDonated,DonatedBy,IsExtinct,FirstDiscoveredDate,LastDiscoveredDate")] ArtifactCreateViewModel artifact)
        {
            if (ModelState.IsValid)
            {
                if (!String.IsNullOrEmpty(artifact.SpeciesText) && artifact.SpeciesId < 1)
                {
                    string[] speciesList = artifact.SpeciesText.Split();
                    if (speciesList.Count() >= 2)
                    {
                        if (!GenusExists(speciesList[0]))
                        {
                            _context.Genus.Add(new Genus() { Name = speciesList[0] });
                            await _context.SaveChangesAsync();
                            int genusId = await _artifactRepository.GetGenusByName(speciesList[0]);
                            if (!SpeciesExists(artifact.SpeciesText) && genusId >= 1)
                            {
                                _context.Species.Add(new Species() { GenusId = genusId, Name = artifact.SpeciesText });
                                await _context.SaveChangesAsync();
                                int speciesId = await _artifactRepository.GetSpeciesByName(artifact.SpeciesText);
                                if (speciesId >= 1)
                                {
                                    artifact.SpeciesId = speciesId;
                                }
                            }
                            else
                            {

                            }
                        }
                        else
                        {
                            int genusId = await _artifactRepository.GetGenusByName(speciesList[0]);
                        }
                        
                    }
                }
                _context.Add(artifact);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClassId"] = new SelectList(_context.Class, "Id", "Id", artifact.ClassId);
            ViewData["FamilyId"] = new SelectList(_context.Family, "Id", "Id", artifact.FamilyId);
            ViewData["KingdomId"] = new SelectList(_context.Kingdom, "Id", "Id", artifact.KingdomId);
            ViewData["OwnerId"] = new SelectList(_context.Owner, "Id", "Id", artifact.OwnerId);
            ViewData["PhylumId"] = new SelectList(_context.Phylum, "Id", "Id", artifact.PhylumId);
            ViewData["SourceId"] = new SelectList(_context.Source, "Id", "Id", artifact.SourceId);
            ViewData["SpeciesId"] = new SelectList(_context.Species, "Id", "Id", artifact.SpeciesId);
            return View(artifact);
        }

        [HttpPost]
        public async Task<ActionResult> AddNewClass(string newClassName)
        {
            var newClass = Request.Form["AddNewClassTxt"];
            _context.Class.Add(new Class() { Name = newClassName });
            await _context.SaveChangesAsync();
            return Content("Made it");
        }

        // GET: Artifacts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artifact = await _context.Artifact.FindAsync(id);
            if (artifact == null)
            {
                return NotFound();
            }
            ViewData["ClassId"] = new SelectList(_context.Class, "Id", "Id", artifact.ClassId);
            ViewData["FamilyId"] = new SelectList(_context.Family, "Id", "Id", artifact.FamilyId);
            ViewData["KingdomId"] = new SelectList(_context.Kingdom, "Id", "Id", artifact.KingdomId);
            ViewData["OwnerId"] = new SelectList(_context.Owner, "Id", "Id", artifact.OwnerId);
            ViewData["PhylumId"] = new SelectList(_context.Phylum, "Id", "Id", artifact.PhylumId);
            ViewData["SourceId"] = new SelectList(_context.Source, "Id", "Id", artifact.SourceId);
            ViewData["SpeciesId"] = new SelectList(_context.Species, "Id", "Id", artifact.SpeciesId);
            return View(artifact);
        }

        // POST: Artifacts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CommonNameOne,CommonNameTwo,CommonNameThree,CommonNameFour,CommonNameFive,Description,ClassId,FamilyId,KingdomId,PhylumId,SpeciesId,SourceId,OwnerId,Quantity,ApproxValue,AquiredDate,IsDonated,DonatedBy,IsExtinct,FirstDiscoveredDate,LastDiscoveredDate")] Artifact artifact)
        {
            if (id != artifact.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(artifact);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArtifactExists(artifact.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClassId"] = new SelectList(_context.Class, "Id", "Id", artifact.ClassId);
            ViewData["FamilyId"] = new SelectList(_context.Family, "Id", "Id", artifact.FamilyId);
            ViewData["KingdomId"] = new SelectList(_context.Kingdom, "Id", "Id", artifact.KingdomId);
            ViewData["OwnerId"] = new SelectList(_context.Owner, "Id", "Id", artifact.OwnerId);
            ViewData["PhylumId"] = new SelectList(_context.Phylum, "Id", "Id", artifact.PhylumId);
            ViewData["SourceId"] = new SelectList(_context.Source, "Id", "Id", artifact.SourceId);
            ViewData["SpeciesId"] = new SelectList(_context.Species, "Id", "Id", artifact.SpeciesId);
            return View(artifact);
        }

        // GET: Artifacts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artifact = await _context.Artifact
                .Include(a => a.Class)
                .Include(a => a.Family)
                .Include(a => a.Kingdom)
                .Include(a => a.Owner)
                .Include(a => a.Phylum)
                .Include(a => a.Source)
                .Include(a => a.Species)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (artifact == null)
            {
                return NotFound();
            }

            return View(artifact);
        }

        // POST: Artifacts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var artifact = await _context.Artifact.FindAsync(id);
            _context.Artifact.Remove(artifact);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArtifactExists(int id)
        {
            return _context.Artifact.Any(e => e.Id == id);
        }

        private bool GenusExists(string name)
        {
            return _context.Genus.Any(e => e.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        private bool SpeciesExists(string name)
        {
            return _context.Species.Any(e => e.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
