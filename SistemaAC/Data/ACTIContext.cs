using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ACTI.Models;
using System.Threading;
using ACTI.Helpers;

namespace ACTI.Data
{
    public class ACTIContext : DbContext
    {
        private readonly DbContextOptions<ACTIContext> optionsoptions;
        private readonly IServicioUsuarioActual servicioUsuarioActual;
        public ACTIContext (DbContextOptions<ACTIContext> options, IServicioUsuarioActual servicioUsuarioActual)
            : base(options)
        {
          
            this.servicioUsuarioActual = servicioUsuarioActual ?? throw new ArgumentNullException(nameof(servicioUsuarioActual));
        }

        public DbSet<ACTI.Models.Alumno> Alumno { get; set; }

        public DbSet<ACTI.Models.Profesor> Profesor { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            ProcesarSalvado();
            return base.SaveChangesAsync(cancellationToken);
        }

        private void ProcesarSalvado()
        {
            var horaActual = DateTime.Now;
            foreach (var item in ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Added && e.Entity is Entidad))
            {
                var entidad = item.Entity as Entidad;
                entidad.FechaCreacion = horaActual;
                entidad.UsuarioCreacion = servicioUsuarioActual.ObtenerNombreUsuarioActual();
                entidad.FechaModificacion = horaActual;
                entidad.UsuarioModificacion = servicioUsuarioActual.ObtenerNombreUsuarioActual();
            }

            foreach (var item in ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Modified && e.Entity is Entidad))
            {
                var entidad = item.Entity as Entidad;
                entidad.FechaModificacion = horaActual;
                entidad.UsuarioModificacion = servicioUsuarioActual.ObtenerNombreUsuarioActual();
                item.Property(nameof(entidad.FechaCreacion)).IsModified = false;
                item.Property(nameof(entidad.UsuarioCreacion)).IsModified = false;
            }
        }
    }
}
