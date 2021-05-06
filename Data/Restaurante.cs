using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SiberianTestFront.Data
{
    public class Restaurante
    {
        public int _id_restaurante { get; set; }

        [Required (ErrorMessage = "Este campo es requerido")]
        public string _nombre_restaurante {get;set;}
        public int _id_ciudad { get; set; }
        public string _nombre_ciudad { get; set; }
        [Range(1,10000, ErrorMessage = "Tiene que ser un valor entre 1-10000")]
        public int _numero_aforo { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string _telefono { get; set; }
        public string _fecha_creacion {get;set;}
}
}
