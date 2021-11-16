using System;
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

        [Display(Name = "Descripcion")]
        [Required(ErrorMessage = "Ingrese la descripcion")]
        [MinLength(3, ErrorMessage = "Ingrese  minimo 3 caracteres")]
        public string Descripcion { get; set; }

        [Display(Name = "Articulo")]
        [Required(ErrorMessage = "Ingrese un nombre para el producto")]
        [MinLength(3, ErrorMessage = "Ingrese  minimo 3 caracteres")]
        public string Art { get; set; }

        [Display(Name = "Marca")]
        [Required(ErrorMessage = "Ingrese la descripcion")]
        [MinLength(3, ErrorMessage = "Ingrese  minimo 3 caracteres")]
        public string Marca{ get; set; }

       

        [Required(ErrorMessage = "Ingrese el precio")]
        [Range(0,3000, ErrorMessage = "Ingrese un precio entre 0 y 3000")]
        public double Precio { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        //Para las imagenes 
        [Display(Name = "Imagen")] //Principal
        public string UrlImagen { get; set; }

        [Display(Name = "Imagen2")]
        public string UrlImagen2 { get; set; }
        
        [Display(Name = "Imagen3")]
        public string UrlImagen3 { get; set; }
         
        [Display(Name = "Imagen4")]
        public string UrlImagen4 { get; set; }
        //Para las imagenes


        public bool Activo { get; set; }

    }
}
