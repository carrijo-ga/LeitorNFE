using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeitorNfe.Data;
using LeitorNfe.Models;

namespace LeitorNfe.Controllers
{
    public class EmitentesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmitentesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Emitentes
        public async Task<IActionResult> Index()
        {
              return _context.Emitentes != null ? 
                          View(await _context.Emitentes.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Emitentes'  is null.");
        }

        // GET: Emitentes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Emitentes == null)
            {
                return NotFound();
            }

            var emitente = await _context.Emitentes
                .FirstOrDefaultAsync(m => m.IDEmitente == id);
            if (emitente == null)
            {
                return NotFound();
            }

            return View(emitente);
        }

        // GET: Emitentes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Emitentes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDEmitente,nome,IDEndereco,cnpj,email")] Emitente emitente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(emitente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(emitente);
        }

        // GET: Emitentes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Emitentes == null)
            {
                return NotFound();
            }

            var emitente = await _context.Emitentes.FindAsync(id);
            if (emitente == null)
            {
                return NotFound();
            }
            return View(emitente);
        }

        // POST: Emitentes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDEmitente,nome,IDEndereco,cnpj,email")] Emitente emitente)
        {
            if (id != emitente.IDEmitente)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(emitente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmitenteExists(emitente.IDEmitente))
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
            return View(emitente);
        }

        // GET: Emitentes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Emitentes == null)
            {
                return NotFound();
            }

            var emitente = await _context.Emitentes
                .FirstOrDefaultAsync(m => m.IDEmitente == id);
            if (emitente == null)
            {
                return NotFound();
            }

            return View(emitente);
        }

        // POST: Emitentes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Emitentes == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Emitentes'  is null.");
            }
            var emitente = await _context.Emitentes.FindAsync(id);
            if (emitente != null)
            {
                _context.Emitentes.Remove(emitente);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmitenteExists(int id)
        {
          return (_context.Emitentes?.Any(e => e.IDEmitente == id)).GetValueOrDefault();
        }
    }
}
