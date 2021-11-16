using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonDeBelleza.BL
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese el nombre del cliente")]
        [MinLength(3, ErrorMessage = "Ingrese mínimo 3 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Ingrese el telefono")]
        [MinLength(8, ErrorMessage = "El telefono debe ser de 8 digitos minimo")]
        [MaxLength(13, ErrorMessage = "El telefono debe ser de 13 digitos maximo")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Ingrese la direccion")]
        [MinLength(3, ErrorMessage = "Ingrese mínimo 3 caracteres")]
        public string Direccion { get; set; }
        public bool Activo { get; set; }

        [MinLength(8, ErrorMessage = "El RTN debe ser de 8 digitos minimo")]
        public string Rtn{ get; set; }

        [MinLength(8, ErrorMessage = "La id debe ser de 13 digitos minimo")]
        public string Identidad { get; set; }
    }
}
