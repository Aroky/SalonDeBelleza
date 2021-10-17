﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonDeBelleza.BL
{
    public class Producto
    {
        public Producto()
        {
            Activo = true;
        }
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese la descripción")]
        [MinLength(3, ErrorMessage = "Ingrese mínimo 3 caracteres")]
        [MaxLength(20, ErrorMessage = "No se permiten más de 20 caracteres")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Ingrese precio")]
        [Range(0, 2000, ErrorMessage = "Ingrese un precio entre 0 y 2000")]
        public double Precio { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        [Display(Name = "Imagen")]
        public string UrlImagen { get; set; }

        public bool Activo { get; set; }
    }
}
