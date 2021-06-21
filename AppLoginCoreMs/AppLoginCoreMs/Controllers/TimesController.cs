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
    public class TimesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TimesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Times
        public async Task<IActionResult> Index()
        {
            return View(await _context.time.ToListAsync());
        }

        // GET: Times/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var time = await _context.time
                .FirstOrDefaultAsync(m => m.id == id);
            if (time == null)
            {
                return NotFound();
            }

            return View(time);
        }

        // GET: Times/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Times/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,timeAct")] Time time)
        {
            if (ModelState.IsValid)
            {
                _context.Add(time);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(time);
        }

        // GET: Times/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var time = await _context.time.FindAsync(id);
            if (time == null)
            {
                return NotFound();
            }
            return View(time);
        }

        // POST: Times/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("id,timeAct")] Time time)
        {
            if (id != time.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(time);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TimeExists(time.id))
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
            return View(time);
        }

        // GET: Times/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var time = await _context.time
                .FirstOrDefaultAsync(m => m.id == id);
            if (time == null)
            {
                return NotFound();
            }

            return View(time);
        }

        // POST: Times/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var time = await _context.time.FindAsync(id);
            _context.time.Remove(time);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TimeExists(long id)
        {
            return _context.time.Any(e => e.id == id);
        }
    }
}
