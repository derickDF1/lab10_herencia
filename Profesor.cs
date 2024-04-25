using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab10_herencia
{
    public class Profesor : Persona
    {
        public string Titulo { get; set; }
        public int NumColegiado { get; set; }

        public Profesor()
        {
            Titulo = string.Empty;
            NumColegiado = 0;
        }
    }
}
