using ACTI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ACTI.Models;


namespace ACTI.Data
{ 
        public class DbInitializer
        {
            public static void Initialize(ACTIContext context)
            {
                context.Database.EnsureCreated();

                //Buscar si existen registros en la tabla categoría
                if (context.Profesor.Any())
                {
                    return;
                }
                var profesores = new Profesor[]
                {
                new Profesor{Dni=31051191,Nombre="Carlos",Apellido="Lamana",Dirección="Cafayate 5148"
                ,Nacimiento=Convert.ToDateTime("1986-03-24T00:00:00"),Email="lanama@gmail.com"
                ,Teléfono=1559046244,Estado=true},
                 new Profesor{Dni=31051111,Nombre="Emmanuel",Apellido="Sanatori",Dirección="Rojas 5148"
                ,Nacimiento=Convert.ToDateTime("1990-08-17T00:00:00"),Email="sanatori@gmail.com"
                ,Teléfono=1560005425,Estado=true},
                 new Profesor{Dni=29065487,Nombre="Miguel",Apellido="Villelli",Dirección="Roca 5896"
                ,Nacimiento=Convert.ToDateTime("1991-08-17T00:00:00"),Email="villelli@gmail.com"
                ,Teléfono=153604599,Estado=true},
                 new Profesor{Dni=29065487,Nombre="Gaston",Apellido="Damico",Dirección="Pia 123"
                ,Nacimiento=Convert.ToDateTime("1997-01-27T00:00:00"),Email="damico@gmail.com"
                ,Teléfono=1589984755,Estado=true},
                 new Profesor{Dni=31051191,Nombre="Martin",Apellido="Muiller",Dirección="Cafayate 5148"
                ,Nacimiento=Convert.ToDateTime("1986-03-24T00:00:00"),Email="muiller@gmail.com"
                ,Teléfono=1559046244,Estado=true},
                 new Profesor{Dni=31051111,Nombre="Rita",Apellido="Lopez",Dirección="Rojas 5148"
                ,Nacimiento=Convert.ToDateTime("1990-08-17T00:00:00"),Email="lopez@gmail.com"
                ,Teléfono=1560005425,Estado=true},
                 new Profesor{Dni=26065487,Nombre="Hector",Apellido="Sala",Dirección="Roca 5896"
                ,Nacimiento=Convert.ToDateTime("1991-08-17T00:00:00"),Email="Sala@gmail.com"
                ,Teléfono=153604599,Estado=true},
                 new Profesor{Dni=290586487,Nombre="Graciela",Apellido="Avila",Dirección="Callao 1123"
                ,Nacimiento=Convert.ToDateTime("1995-06-10T00:00:00"),Email="avila@gmail.com"
                ,Teléfono=15563266,Estado=true}

                };

                foreach (Profesor c in profesores)
                {
                    context.Profesor.Add(c);
                }
                context.SaveChanges();
                context.Database.EnsureCreated();

                //Buscar si existen registros en la tabla categoría
                if (context.Alumno.Any())
                {
                    return;
                }
                var alumnos = new Alumno[]
                {
                 new Alumno{Dni=31051191,Nombre="Pablo",Apellido="Navarro",Dirección="Cafayate 5148"
                ,Nacimiento=Convert.ToDateTime("1986-03-24T00:00:00"),Email="navarro@gmail.com"
                ,Teléfono=1559046244,Estado=true},
                 new Alumno{Dni=31051111,Nombre="Carlos",Apellido="Lopez",Dirección="Rojas 5148"
                ,Nacimiento=Convert.ToDateTime("1990-08-17T00:00:00"),Email="lopez@gmail.com"
                ,Teléfono=1560005425,Estado=true},
                 new Alumno{Dni=29065487,Nombre="Tomas",Apellido="Sala",Dirección="Roca 5896"
                ,Nacimiento=Convert.ToDateTime("1991-08-17T00:00:00"),Email="Sala@gmail.com"
                ,Teléfono=153604599,Estado=true},
                 new Alumno{Dni=29065487,Nombre="Romina",Apellido="Garcia",Dirección="Pia 123"
                ,Nacimiento=Convert.ToDateTime("1997-01-27T00:00:00"),Email="garcia@gmail.com"
                ,Teléfono=1589984755,Estado=true},
                 new Alumno{Dni=31051191,Nombre="Pablo",Apellido="Navarro",Dirección="Cafayate 5148"
                ,Nacimiento=Convert.ToDateTime("1986-03-24T00:00:00"),Email="navarro@gmail.com"
                ,Teléfono=1559046244,Estado=true},
                 new Alumno{Dni=31051111,Nombre="Carlos",Apellido="Lopez",Dirección="Rojas 5148"
                ,Nacimiento=Convert.ToDateTime("1990-08-17T00:00:00"),Email="lopez@gmail.com"
                ,Teléfono=1560005425,Estado=true},
                 new Alumno{Dni=26065487,Nombre="Tomas",Apellido="Sala",Dirección="Roca 5896"
                ,Nacimiento=Convert.ToDateTime("1991-08-17T00:00:00"),Email="Sala@gmail.com"
                ,Teléfono=153604599,Estado=true},
                 new Alumno{Dni=290586487,Nombre="Laura",Apellido="Avila",Dirección="Callao 1123"
                ,Nacimiento=Convert.ToDateTime("1995-06-10T00:00:00"),Email="avila@gmail.com"
                ,Teléfono=15563266,Estado=true},
                 new Alumno{Dni=28065487,Nombre="Miguel",Apellido="Herrero",Dirección="Florida 23"
                ,Nacimiento=Convert.ToDateTime("1985-07-05T00:00:00"),Email="herrero@gmail.com"
                ,Teléfono=1554066244,Estado=true},
                 new Alumno{Dni=27065487,Nombre="Gabriel",Apellido="Colon",Dirección="Rivadavia 523"
                ,Nacimiento=Convert.ToDateTime("1995-07-05T00:00:00"),Email="colon@gmail.com"
                ,Teléfono=1547053688,Estado=true},
                 new Alumno{Dni=31052291,Nombre="Javier",Apellido="Luna",Dirección="Napoleon 148"
                ,Nacimiento=Convert.ToDateTime("1985-03-24T00:00:00"),Email="luna@gmail.com"
                ,Teléfono=1559046244,Estado=true},
                 new Alumno{Dni=31051111,Nombre="Agustin",Apellido="Gonzalez",Dirección="Cruz 5148"
                ,Nacimiento=Convert.ToDateTime("1990-08-17T00:00:00"),Email="gonzalez@gmail.com"
                ,Teléfono=1560005425,Estado=true},
                 new Alumno{Dni=29065487,Nombre="Tomas",Apellido="Sala",Dirección="Roca 5896"
                ,Nacimiento=Convert.ToDateTime("1991-08-17T00:00:00"),Email="Sala@gmail.com"
                ,Teléfono=153604599,Estado=true},
                 new Alumno{Dni=29065487,Nombre="Paula",Apellido="Garcia",Dirección="Pia 123"
                ,Nacimiento=Convert.ToDateTime("1997-01-27T00:00:00"),Email="garcia@gmail.com"
                ,Teléfono=1589984755,Estado=true},
                 new Alumno{Dni=31051191,Nombre="Laura",Apellido="Navarro",Dirección="Cafayate 5148"
                ,Nacimiento=Convert.ToDateTime("1986-03-24T00:00:00"),Email="navarro@gmail.com"
                ,Teléfono=1559046244,Estado=true},
                 new Alumno{Dni=31051111,Nombre="Patricio",Apellido="Lopez",Dirección="Rojas 5148"
                ,Nacimiento=Convert.ToDateTime("1990-08-17T00:00:00"),Email="lopez@gmail.com"
                ,Teléfono=1560005425,Estado=true},
                 new Alumno{Dni=26065487,Nombre="Nicolas",Apellido="Sala",Dirección="Roca 5896"
                ,Nacimiento=Convert.ToDateTime("1991-08-17T00:00:00"),Email="Sala@gmail.com"
                ,Teléfono=153604599,Estado=true},
                 new Alumno{Dni=290586487,Nombre="Renzo",Apellido="Avila",Dirección="Callao 1123"
                ,Nacimiento=Convert.ToDateTime("1995-06-10T00:00:00"),Email="avila@gmail.com"
                ,Teléfono=15563266,Estado=true},
                 new Alumno{Dni=28065487,Nombre="Fernando",Apellido="Herrero",Dirección="Florida 23"
                ,Nacimiento=Convert.ToDateTime("1985-07-05T00:00:00"),Email="herrero@gmail.com"
                ,Teléfono=1554066244,Estado=true},
                 new Alumno{Dni=27065487,Nombre="Matias",Apellido="Colon",Dirección="Rivadavia 523"
                ,Nacimiento=Convert.ToDateTime("1995-07-05T00:00:00"),Email="colon@gmail.com"
                ,Teléfono=1547053688,Estado=true}

                };

                foreach (Alumno c in alumnos)
                {
                    context.Alumno.Add(c);
                }
                context.SaveChanges();

            }
        }
    
}
