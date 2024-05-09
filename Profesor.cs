using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lab10_herencia
{
    public class Profesor : Persona
    {

        [Required(ErrorMessage = "El titulo es requerido")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "El Colegiado es requerido es requerido")]
        [StringLength(6, ErrorMessage = "Deben ser menos de 6 digitos")]
        public string NumColegiado { get; set; }

        public Profesor()
        {
            Titulo = string.Empty;
            NumColegiado = string.Empty;
        }
    }
}
