using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ACTI.Models
{
    public class Alumno
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public int Dni { get; set; }

        [Required(ErrorMessage = "Campo requerido")]

        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo requerido")]

        public string Apellido { get; set; }

        [Required(ErrorMessage = "Campo requerido")]

        public string Dirección { get; set; }
        public DateTime Nacimiento { get; set; }
        public string Email { get; set; }
        public int Teléfono { get; set; }
        public Boolean Estado { get; set; }
        [ForeignKey("ProfesorId")]
        public virtual Profesor Profesor { get; set; }
    }
}
