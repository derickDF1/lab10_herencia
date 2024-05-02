using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace lab10_herencia
{
    public class Profesor : Persona
    {
        [Required(ErrorMessage = "El titulo es requerido")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "El Colegiado es requerido es requerido")]
        [StringLength(6, ErrorMessage = "Deben ser menos de 6 digitos")]
        public int NumColegiado { get; set; }

        public Profesor()
        {
            Titulo = string.Empty;
            NumColegiado = 0;
        }
    }
}
