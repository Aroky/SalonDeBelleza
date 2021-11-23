using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonDeBelleza.BL
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            var nuevoUsuario1 = new Usuario();
            nuevoUsuario1.Nombre = "Aroky Cruz";
            nuevoUsuario1.Contrasena = Encriptar.CodificarContrasena("001");

            contexto.Usuarios.Add(nuevoUsuario1);

            var nuevoUsuario2 = new Usuario();
            nuevoUsuario2.Nombre = "Bryan Zavala";
            nuevoUsuario2.Contrasena = Encriptar.CodificarContrasena("002");

            contexto.Usuarios.Add(nuevoUsuario2);

            var nuevoUsuario3 = new Usuario();
            nuevoUsuario3.Nombre = "Gladys Sosa";
            nuevoUsuario3.Contrasena = Encriptar.CodificarContrasena("003");

            contexto.Usuarios.Add(nuevoUsuario3);

            var nuevoUsuario4 = new Usuario();
            nuevoUsuario4.Nombre = "James Zavala";
            nuevoUsuario4.Contrasena = Encriptar.CodificarContrasena("004");

            contexto.Usuarios.Add(nuevoUsuario4);

            base.Seed(contexto);
        }
    }
}
