using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ACTI.Models;

namespace ACTI.Data
{
    public class ACTIContext : DbContext
    {
        public ACTIContext (DbContextOptions<ACTIContext> options)
            : base(options)
        {
        }

        public DbSet<ACTI.Models.Alumno> Alumno { get; set; }

        public DbSet<ACTI.Models.Profesor> Profesor { get; set; }
    }
}
