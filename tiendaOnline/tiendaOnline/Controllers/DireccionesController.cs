﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using tiendaOnline.Data;
using tiendaOnline.Models;

namespace tiendaOnline.Controllers
{
    public class DireccionesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DireccionesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Direcciones
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Direccion.Include(d => d.Municipio).Include(d => d.detalleVendedor).Include(d => d.tiendaOnlineUser);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Direcciones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var direccion = await _context.Direccion
                .Include(d => d.Municipio)
                .Include(d => d.detalleVendedor)
                .Include(d => d.tiendaOnlineUser)
                .FirstOrDefaultAsync(m => m.DireccionID == id);
            if (direccion == null)
            {
                return NotFound();
            }

            return View(direccion);
        }

        // GET: Direcciones/Create
        public IActionResult Create()
        {
            ViewData["MunicipioID"] = new SelectList(_context.Municipio, "MunicipioID", "nombreMunicipio");
            ViewData["detalleVendedorID"] = new SelectList(_context.DetalleVendedor, "DetalleVendedorID", "correoComercial");
            ViewData["tiendaOnlineUserID"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Direcciones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DireccionID,direccionDetallada,codigoPostal,MunicipioID,tiendaOnlineUserID,detalleVendedorID")] Direccion direccion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(direccion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MunicipioID"] = new SelectList(_context.Municipio, "MunicipioID", "nombreMunicipio", direccion.MunicipioID);
            ViewData["detalleVendedorID"] = new SelectList(_context.DetalleVendedor, "DetalleVendedorID", "correoComercial", direccion.detalleVendedorID);
            ViewData["tiendaOnlineUserID"] = new SelectList(_context.Users, "Id", "Id", direccion.tiendaOnlineUserID);
            return View(direccion);
        }

        // GET: Direcciones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var direccion = await _context.Direccion.FindAsync(id);
            if (direccion == null)
            {
                return NotFound();
            }
            ViewData["MunicipioID"] = new SelectList(_context.Municipio, "MunicipioID", "nombreMunicipio", direccion.MunicipioID);
            ViewData["detalleVendedorID"] = new SelectList(_context.DetalleVendedor, "DetalleVendedorID", "correoComercial", direccion.detalleVendedorID);
            ViewData["tiendaOnlineUserID"] = new SelectList(_context.Users, "Id", "Id", direccion.tiendaOnlineUserID);
            return View(direccion);
        }

        // POST: Direcciones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DireccionID,direccionDetallada,codigoPostal,MunicipioID,tiendaOnlineUserID,detalleVendedorID")] Direccion direccion)
        {
            if (id != direccion.DireccionID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(direccion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DireccionExists(direccion.DireccionID))
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
            ViewData["MunicipioID"] = new SelectList(_context.Municipio, "MunicipioID", "nombreMunicipio", direccion.MunicipioID);
            ViewData["detalleVendedorID"] = new SelectList(_context.DetalleVendedor, "DetalleVendedorID", "correoComercial", direccion.detalleVendedorID);
            ViewData["tiendaOnlineUserID"] = new SelectList(_context.Users, "Id", "Id", direccion.tiendaOnlineUserID);
            return View(direccion);
        }

        // GET: Direcciones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var direccion = await _context.Direccion
                .Include(d => d.Municipio)
                .Include(d => d.detalleVendedor)
                .Include(d => d.tiendaOnlineUser)
                .FirstOrDefaultAsync(m => m.DireccionID == id);
            if (direccion == null)
            {
                return NotFound();
            }

            return View(direccion);
        }

        // POST: Direcciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var direccion = await _context.Direccion.FindAsync(id);
            _context.Direccion.Remove(direccion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DireccionExists(int id)
        {
            return _context.Direccion.Any(e => e.DireccionID == id);
        }
    }
}
