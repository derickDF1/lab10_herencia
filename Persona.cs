using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab10_herencia
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }

        public Persona()
        {
            Nombre = string.Empty;
            Apellido = string.Empty;
            Direccion = string.Empty;
            Edad = 0;
        }

        public int CalcularEdad()
        {
            int edad = 0;

            int mesNacimiento = FechaNacimiento.Month;
            int añoNacimiento = FechaNacimiento.Year;
            int diaNacimiento = FechaNacimiento.Day;

            int mesActual = DateTime.Now.Month;
            int añoActual = DateTime.Now.Year;
            int diaActual = DateTime.Now.Day;

            if (mesActual > mesNacimiento)
            {
                edad = (añoActual - añoNacimiento);
            }
            else if ((mesActual >= mesNacimiento) && (diaActual >= diaNacimiento))
            {
                edad = (añoActual - añoNacimiento);
            }
            else
            {
                edad = (añoActual - añoNacimiento) - 1;
            }
            return edad;
        }
    }
}
