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
using ArtifactsApp.Models.Contracts;

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
        public async Task<IActionResult> Create([Bind("CommonNameOne,CommonNameTwo,CommonNameThree,CommonNameFour,CommonNameFive,Description,KingdomText,PhylumText,ClassText,OrderText,FamilyText,GenusText,SpeciesText,SourceId,OwnerId,Quantity,ApproxValue,AquiredDate,IsDonated,DonatedBy,IsExtinct,FirstDiscoveredDate,LastDiscoveredDate")] ArtifactCreateViewModel artifact)
        {
            if (ModelState.IsValid)
            {
                artifact.KingdomId = await AddKingdom(artifact.KingdomText);
                artifact.PhylumId = await AddPhylum(artifact.PhylumText, artifact.KingdomId);
                artifact.ClassId = await AddClass(artifact.ClassText, artifact.KingdomId, artifact.PhylumId);
                artifact.OrderId = await AddOrder(artifact.OrderText, artifact.KingdomId, artifact.PhylumId, artifact.ClassId);
                artifact.FamilyId = await AddFamily(artifact.OrderText, artifact.KingdomId, artifact.PhylumId, artifact.ClassId, artifact.OrderId);
                int genusId = await AddGenus(artifact.OrderText, artifact.KingdomId, artifact.PhylumId, artifact.ClassId, artifact.OrderId, artifact.FamilyId);
                artifact.SpeciesId = await AddSpecies(artifact.OrderText, artifact.KingdomId, artifact.PhylumId, artifact.ClassId, artifact.OrderId, artifact.FamilyId, genusId); ;
                _context.Add(artifact);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OwnerId"] = new SelectList(_context.Owner, "Id", "Id", artifact.OwnerId);
            ViewData["SourceId"] = new SelectList(_context.Source, "Id", "Id", artifact.SourceId);
            ViewData["SpeciesId"] = new SelectList(_context.Species, "Id", "Id", artifact.SpeciesId);
            return View(artifact);
        }

        public async Task<int?> AddKingdom(string kingdomText)
        {
            if (!String.IsNullOrEmpty(kingdomText))
            {
                var kingdomId = await _artifactRepository.KingdomExists(kingdomText);
                if (kingdomId != null)
                {
                    return kingdomId;
                }
                else
                {
                    Kingdom newKing = new Kingdom() { Name = kingdomText };
                    _context.Add(newKing);
                    await _context.SaveChangesAsync();
                    return newKing.Id;
                }
            }
            return null;
        }

        public async Task<int?> AddPhylum(string phylumText, int? kingdomId)
        {
            if (!String.IsNullOrEmpty(phylumText))
            {
                var phylumId = await _artifactRepository.PhylumExists(phylumText);
                if (phylumId != null)
                {
                    return phylumId;
                }
                else
                {
                    Phylum newPhylum = new Phylum() { Name = phylumText, KingdomId = kingdomId };
                    _context.Add(newPhylum);
                    await _context.SaveChangesAsync();
                    return newPhylum.Id;
                }
            }
            return null;
        }

        public async Task<int?> AddClass(string classText, int? kingdomId, int? phylumId)
        {
            if (!String.IsNullOrEmpty(classText))
            {
                var classId = await _artifactRepository.ClassExists(classText);
                if (classId != null)
                {
                    return classId;
                }
                else
                {
                    Class newClass = new Class() { Name = classText, KingdomId = kingdomId, PhylumId = phylumId };
                    _context.Add(newClass);
                    await _context.SaveChangesAsync();
                    return newClass.Id;
                }
            }
            return null;
        }

        public async Task<int?> AddOrder(string orderText, int? kingdomId, int? phylumId, int? classId)
        {
            if (!String.IsNullOrEmpty(orderText))
            {
                var orderId = await _artifactRepository.OrderExists(orderText);
                if (orderId != null)
                {
                    return orderId;
                }
                else
                {
                    Order newOrder = new Order() { Name = orderText, KingdomId = kingdomId, PhylumId = phylumId, ClassId = classId };
                    _context.Add(newOrder);
                    await _context.SaveChangesAsync();
                    return newOrder.Id;
                }
            }
            return null;
        }

        public async Task<int?> AddFamily(string familyText, int? kingdomId, int? phylumId, int? classId, int? orderId)
        {
            if (!String.IsNullOrEmpty(familyText))
            {
                var familyId = await _artifactRepository.FamilyExists(familyText);
                if (familyId != null)
                {
                    return familyId;
                }
                else
                {
                    Family newFamily = new Family() { Name = familyText, KingdomId = kingdomId, PhylumId = phylumId, ClassId = classId, OrderId = orderId };
                    _context.Add(newFamily);
                    await _context.SaveChangesAsync();
                    return newFamily.Id;
                }
            }
            return null;
        }

        public async Task<int> AddGenus(string genusText, int? kingdomId, int? phylumId, int? classId, int? orderId, int? familyId)
        {
            if (!String.IsNullOrEmpty(genusText))
            {
                var genusId = await _artifactRepository.GenusExists(genusText);
                if (genusId != null)
                {
                    return (int)genusId;
                }
                else
                {
                    Genus newGenus = new Genus() { Name = genusText, KingdomId = kingdomId, PhylumId = phylumId, ClassId = classId, OrderId = orderId, FamilyId = familyId };
                    _context.Add(newGenus);
                    await _context.SaveChangesAsync();
                    return newGenus.Id;
                }
            }
            return -1;
        }

        public async Task<int?> AddSpecies(string speciesText, int? kingdomId, int? phylumId, int? classId, int? orderId, int? familyId, int genusId)
        {
            if (!String.IsNullOrEmpty(speciesText))
            {
                var speciesId = await _artifactRepository.SpeciesExists(speciesText);
                if (speciesId != null)
                {
                    return speciesId;
                }
                else
                {
                    Species newSpecies = new Species() { Name = speciesText, KingdomId = kingdomId, PhylumId = phylumId, ClassId = classId, FamilyId = familyId, GenusId = genusId };
                    _context.Add(newSpecies);
                    await _context.SaveChangesAsync();
                    return newSpecies.Id;
                }
            }
            return null;
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
            ViewData["OwnerId"] = new SelectList(_context.Owner, "Id", "Id", artifact.OwnerId);
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
    }
}
