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
    public class DestinatariosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DestinatariosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Destinatarios
        public async Task<IActionResult> Index()
        {
              return _context.Destinatarios != null ? 
                          View(await _context.Destinatarios.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Destinatarios'  is null.");
        }

        // GET: Destinatarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Destinatarios == null)
            {
                return NotFound();
            }

            var destinatario = await _context.Destinatarios
                .FirstOrDefaultAsync(m => m.IDDestinatario == id);
            if (destinatario == null)
            {
                return NotFound();
            }

            return View(destinatario);
        }

        // GET: Destinatarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Destinatarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDDestinatario,nome,IDEndereco,cnpj,email")] Destinatario destinatario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(destinatario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(destinatario);
        }

        // GET: Destinatarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Destinatarios == null)
            {
                return NotFound();
            }

            var destinatario = await _context.Destinatarios.FindAsync(id);
            if (destinatario == null)
            {
                return NotFound();
            }
            return View(destinatario);
        }

        // POST: Destinatarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDDestinatario,nome,IDEndereco,cnpj,email")] Destinatario destinatario)
        {
            if (id != destinatario.IDDestinatario)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(destinatario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DestinatarioExists(destinatario.IDDestinatario))
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
            return View(destinatario);
        }

        // GET: Destinatarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Destinatarios == null)
            {
                return NotFound();
            }

            var destinatario = await _context.Destinatarios
                .FirstOrDefaultAsync(m => m.IDDestinatario == id);
            if (destinatario == null)
            {
                return NotFound();
            }

            return View(destinatario);
        }

        // POST: Destinatarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Destinatarios == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Destinatarios'  is null.");
            }
            var destinatario = await _context.Destinatarios.FindAsync(id);
            if (destinatario != null)
            {
                _context.Destinatarios.Remove(destinatario);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DestinatarioExists(int id)
        {
          return (_context.Destinatarios?.Any(e => e.IDDestinatario == id)).GetValueOrDefault();
        }
    }
}
