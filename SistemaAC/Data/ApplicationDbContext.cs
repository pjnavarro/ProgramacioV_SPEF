using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ACTI.Models;
using System.Threading;
using ACTI.Helpers;

namespace ACTI.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        private readonly IServicioUsuarioActual servicioUsuarioActual;

        // private readonly IServicioUsuarioActual servicioUsuarioActual;


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IServicioUsuarioActual servicioUsuarioActual)
            : base(options)
        {
            this.servicioUsuarioActual = servicioUsuarioActual ?? throw new ArgumentNullException(nameof(servicioUsuarioActual));
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<ACTI.Models.ApplicationUser> ApplicationUser { get; set; }
       

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            ProcesarSalvado();
            return base.SaveChangesAsync(cancellationToken);
        }

        private void ProcesarSalvado()
        {
            var horaActual = DateTimeOffset.UtcNow;
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
