using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab10_herencia
{
    public class Administrativo : Persona
    {
        public string Profesion { get; set; }
        public int NumeroIgss { get; set; }

        public Administrativo()
        {
            Profesion = string.Empty;
            NumeroIgss = 0;
        }
    }
}
