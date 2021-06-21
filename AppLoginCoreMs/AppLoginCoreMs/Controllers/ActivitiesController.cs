using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AppLoginCoreMs.Data;
using AppLoginCoreMs.Models;

namespace AppLoginCoreMs.Controllers
{
    public class ActivitiesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ActivitiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Activities
        public async Task<IActionResult> Index()
        {
            return View(await _context.activities.ToListAsync());
        }

        // GET: Activities/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var activities = await _context.activities
                .FirstOrDefaultAsync(m => m.id == id);
            if (activities == null)
            {
                return NotFound();
            }

            return View(activities);
        }

        // GET: Activities/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Activities/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,name,dateAct,employee")] Activities activities)
        {
            if (ModelState.IsValid)
            {
                _context.Add(activities);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(activities);
        }

        // GET: Activities/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var activities = await _context.activities.FindAsync(id);
            if (activities == null)
            {
                return NotFound();
            }
            return View(activities);
        }

        // POST: Activities/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("id,name,dateAct,employee")] Activities activities)
        {
            if (id != activities.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(activities);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ActivitiesExists(activities.id))
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
            return View(activities);
        }

        // GET: Activities/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var activities = await _context.activities
                .FirstOrDefaultAsync(m => m.id == id);
            if (activities == null)
            {
                return NotFound();
            }

            return View(activities);
        }

        // POST: Activities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var activities = await _context.activities.FindAsync(id);
            _context.activities.Remove(activities);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ActivitiesExists(long id)
        {
            return _context.activities.Any(e => e.id == id);
        }
    }
}
