using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SiberianTestFront.Data
{
    public class Ciudad
    {
        public int _id_ciudad { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string _nombre_ciudad { get; set; }
    }
}
