using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ACTI.Data;
using ACTI.Models;
using Microsoft.AspNetCore.Authorization;

namespace ACTI.Controllers
{
    public class ProfesoresController : Controller
    {
        private readonly ACTIContext _context;

        public ProfesoresController(ACTIContext context)
        {
            _context = context;
        }
        [Authorize]
        // GET: Profesores
        public async Task<IActionResult> Index(string sortOrder,
                                       string currentFilter, string searchString,
                                       int? page)
        {
            ViewData["NombreSortParm"] = String.IsNullOrEmpty(sortOrder) ? "nombre_desc" : "";
            ViewData["ApellidoSortParm"] = sortOrder == "apellido_asc" ? "apellido_desc" : "apellido_asc";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;
            ViewData["CurrentSort"] = sortOrder;

            var profesores = from s in _context.Profesor select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                profesores = profesores.Where(s => s.Nombre.Contains(searchString) || s.Apellido.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "nombre_desc":
                    profesores = profesores.OrderByDescending(s => s.Nombre);
                    break;
                case "apellido_desc":
                    profesores = profesores.OrderByDescending(s => s.Apellido);
                    break;
                case "apellido_asc":
                    profesores = profesores.OrderBy(s => s.Apellido);
                    break;
                default:
                    profesores = profesores.OrderBy(s => s.Nombre);
                    break;
            }

            int pageSize = 3;
            return View(await Paginacion<Profesor>.CreateAsync(profesores.AsNoTracking(), page ?? 1, pageSize));
            // return View(await _context.Profesor.ToListAsync());
        }

        // GET: Profesores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profesor = await _context.Profesor
                .SingleOrDefaultAsync(m => m.Id == id);
            if (profesor == null)
            {
                return NotFound();
            }

            return View(profesor);
        }

        [Authorize(Roles = "Administrador")]
        // GET: Profesores/Create

        public IActionResult Create()
        {
            return View();
        }

        // POST: Profesores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Dni,Nombre,Apellido,Dirección,Nacimiento,Email,Teléfono,Estado,UsuarioCreacion,FechaCreacion,UsuarioModificacion,FechaModificacion")] Profesor profesor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(profesor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(profesor);
        }
        [Authorize(Roles = "Administrador")]
        // GET: Profesores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profesor = await _context.Profesor.SingleOrDefaultAsync(m => m.Id == id);
            if (profesor == null)
            {
                return NotFound();
            }
            return View(profesor);
        }
        [Authorize(Roles = "Administrador")]
        // POST: Profesores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Dni,Nombre,Apellido,Dirección,Nacimiento,Email,Teléfono,Estado,UsuarioCreacion,FechaCreacion,UsuarioModificacion,FechaModificacion")] Profesor profesor)
        {
            if (id != profesor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(profesor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProfesorExists(profesor.Id))
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
            return View(profesor);
        }
        [Authorize(Roles = "Administrador")]
        // GET: Profesores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profesor = await _context.Profesor
                .SingleOrDefaultAsync(m => m.Id == id);
            if (profesor == null)
            {
                return NotFound();
            }

            return View(profesor);
        }
        [Authorize(Roles = "Administrador")]
        // POST: Profesores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var profesor = await _context.Profesor.SingleOrDefaultAsync(m => m.Id == id);
            _context.Profesor.Remove(profesor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProfesorExists(int id)
        {
            return _context.Profesor.Any(e => e.Id == id);
        }
    }
}
