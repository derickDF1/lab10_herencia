using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab10_herencia
{
    public class Alumno : Persona
    {
        public string Carnet { get; set; }
        public int[] Notas { get; set; }

        public Alumno()
        {
            Carnet = string.Empty;
            Notas = new int[0];
        }
    }
}
