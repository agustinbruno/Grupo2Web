using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda_de_Ropa.Modelos.Enums;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Tienda_de_Ropa.Modelos
{
    public class Empleado
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Usuario { get; set; }

        public string Contraseña { get; set; }

        public int Rol { get; set; }

        public string Imagen { get; set; }

        public string Email { get; set; }

        public Empleado(int id, string nombre,string usuario, string contraseña, int rol, string imagen, string email)
        {
            Id = id;
            Nombre = nombre;
            Usuario = usuario;
            Contraseña = contraseña;
            Rol = rol;
            Imagen = imagen;
            Email = email;
        }

        public Empleado(string nombre, string usuario, string contraseña, int rol, string imagen, string email)
        {
            Nombre = nombre;
            Usuario = usuario;
            Contraseña = contraseña;
            Rol = rol;
            Imagen = imagen;
            Email = email;
        }
        public Empleado(string usuario)
        {
            Usuario = usuario;         
        }

    }
}
