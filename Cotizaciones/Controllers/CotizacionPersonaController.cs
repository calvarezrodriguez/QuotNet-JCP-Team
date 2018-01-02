using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cotizaciones.Data;
using Cotizaciones.Models;

namespace Cotizaciones.Controllers
{
    public class CotizacionPersonaController : Controller
    {
        private readonly CotizacionesContext _context;

        public CotizacionPersonaController(CotizacionesContext context)
        {
            _context = context;
        }

        // GET: CotizacionPersona
        public async Task<IActionResult> Index()
        {
            return View(await _context.CotizacionPersonas.ToListAsync());
        }

        // GET: CotizacionPersona/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cotizacionPersona = await _context.CotizacionPersonas
                .SingleOrDefaultAsync(m => m.CotizacionPersonaID == id);
            if (cotizacionPersona == null)
            {
                return NotFound();
            }

            return View(cotizacionPersona);
        }

        // GET: CotizacionPersona/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CotizacionPersona/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CotizacionPersonaID")] CotizacionPersona cotizacionPersona)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cotizacionPersona);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cotizacionPersona);
        }

        // GET: CotizacionPersona/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cotizacionPersona = await _context.CotizacionPersonas.SingleOrDefaultAsync(m => m.CotizacionPersonaID == id);
            if (cotizacionPersona == null)
            {
                return NotFound();
            }
            return View(cotizacionPersona);
        }

        // POST: CotizacionPersona/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CotizacionPersonaID")] CotizacionPersona cotizacionPersona)
        {
            if (id != cotizacionPersona.CotizacionPersonaID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cotizacionPersona);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CotizacionPersonaExists(cotizacionPersona.CotizacionPersonaID))
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
            return View(cotizacionPersona);
        }

        // GET: CotizacionPersona/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cotizacionPersona = await _context.CotizacionPersonas
                .SingleOrDefaultAsync(m => m.CotizacionPersonaID == id);
            if (cotizacionPersona == null)
            {
                return NotFound();
            }

            return View(cotizacionPersona);
        }

        // POST: CotizacionPersona/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cotizacionPersona = await _context.CotizacionPersonas.SingleOrDefaultAsync(m => m.CotizacionPersonaID == id);
            _context.CotizacionPersonas.Remove(cotizacionPersona);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CotizacionPersonaExists(int id)
        {
            return _context.CotizacionPersonas.Any(e => e.CotizacionPersonaID == id);
        }
    }
}
