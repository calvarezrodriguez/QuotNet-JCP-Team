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
    public class CotizacionController : Controller
    {
        private readonly CotizacionesContext _context;

        public CotizacionController(CotizacionesContext context)
        {
            _context = context;
        }

        // GET: Cotizacion
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cotizaciones.ToListAsync());
        }

        // GET: Cotizacion/Details/
        public async Task<IActionResult> Details(int? correlativoID)
        {
            if (correlativoID == null)
            {
                return NotFound();
            }

            var cotizacion = await _context.Cotizaciones
                .SingleOrDefaultAsync(m => m.correlativoID == correlativoID);
            if (cotizacion == null)
            {
                return NotFound();
            }

            return View(cotizacion);
        }

        // GET: Cotizacion/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cotizacion/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("correlativoID,tipoServicio,descripcion,montoTotal,valorAgregado,fecha")] Cotizacion cotizacion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cotizacion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cotizacion);
        }

        // GET: Cotizacion/Edit/5
        public async Task<IActionResult> Edit(int? correlativoID)
        {
            if (correlativoID == null)
            {
                return NotFound();
            }

            var cotizacion = await _context.Cotizaciones.SingleOrDefaultAsync(m => m.correlativoID == correlativoID);
            if (cotizacion == null)
            {
                return NotFound();
            }
            return View(cotizacion);
        }

        // POST: Cotizacion/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int correlativoID, [Bind("correlativoID,Rut,Nombre,Paterno,Materno")] Cotizacion cotizacion)
        {
            if (correlativoID != cotizacion.correlativoID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cotizacion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CotizacionExists(cotizacion.correlativoID))
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
            return View(cotizacion);
        }

        // GET: Cotizacion/Delete/5
        public async Task<IActionResult> Delete(int? correlativoID)
        {
            if (correlativoID == null)
            {
                return NotFound();
            }

            var cotizacion = await _context.Cotizaciones
                .SingleOrDefaultAsync(m => m.correlativoID == correlativoID);
            if (cotizacion == null)
            {
                return NotFound();
            }

            return View(cotizacion);
        }

        // POST: Cotizacion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int correlativoID)
        {
            var cotizacion = await _context.Cotizaciones.SingleOrDefaultAsync(m => m.correlativoID == correlativoID);
            _context.Cotizaciones.Remove(cotizacion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CotizacionExists(int correlativoID)
        {
            return _context.Cotizaciones.Any(e => e.correlativoID == correlativoID);
        }
    }
}