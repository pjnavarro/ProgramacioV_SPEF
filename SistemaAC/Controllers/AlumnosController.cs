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
    public class AlumnosController : Controller
    {

        private readonly ACTIContext _context;

        public AlumnosController(ACTIContext context)
        {
            _context = context;
        }
        [Authorize]
        // GET: Alumnos
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

            var alumnos = from s in _context.Alumno select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                alumnos = alumnos.Where(s => s.Nombre.Contains(searchString) || s.Apellido.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "nombre_desc":
                    alumnos = alumnos.OrderByDescending(s => s.Nombre);
                    break;
                case "apellido_desc":
                    alumnos = alumnos.OrderByDescending(s => s.Apellido);
                    break;
                case "apellido_asc":
                    alumnos = alumnos.OrderBy(s => s.Apellido);
                    break;
                default:
                    alumnos = alumnos.OrderBy(s => s.Nombre);
                    break;
            }

            int pageSize = 3;
            return View(await Paginacion<Alumno>.CreateAsync(alumnos.AsNoTracking(), page ?? 1, pageSize));
            // return View(await _context.Alumno.ToListAsync());
        }

        // GET: Alumnos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alumno = await _context.Alumno
                .SingleOrDefaultAsync(m => m.Id == id);
            if (alumno == null)
            {
                return NotFound();
            }

            return View(alumno);
        }
        [Authorize(Roles = "Administrador")]
        // GET: Alumnos/Create
        public IActionResult Create()
        {
            return View();
        }
        [Authorize(Roles = "Administrador")]
        // POST: Alumnos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Dni,Nombre,Apellido,Dirección,Nacimiento,Email,Teléfono,Estado")] Alumno alumno)
        {
            if (ModelState.IsValid)
            {
                _context.Add(alumno);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(alumno);
        }
        [Authorize(Roles = "Administrador")]
        // GET: Alumnos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alumno = await _context.Alumno.SingleOrDefaultAsync(m => m.Id == id);
            if (alumno == null)
            {
                return NotFound();
            }
            return View(alumno);
        }
        [Authorize(Roles = "Administrador")]
        // POST: Alumnos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Dni,Nombre,Apellido,Dirección,Nacimiento,Email,Teléfono,Estado")] Alumno alumno)
        {
            if (id != alumno.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(alumno);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlumnoExists(alumno.Id))
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
            return View(alumno);
        }
        [Authorize(Roles = "Administrador")]
        // GET: Alumnos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alumno = await _context.Alumno
                .SingleOrDefaultAsync(m => m.Id == id);
            if (alumno == null)
            {
                return NotFound();
            }

            return View(alumno);
        }
       
        [Authorize(Roles = "Administrador")]
        // POST: Alumnos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var alumno = await _context.Alumno.SingleOrDefaultAsync(m => m.Id == id);
            _context.Alumno.Remove(alumno);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlumnoExists(int id)
        {
            return _context.Alumno.Any(e => e.Id == id);
        }
    }
}
