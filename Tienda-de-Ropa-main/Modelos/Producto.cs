using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda_de_Ropa.Modelos
{
    public class Producto
    {
        public int Id { get; set; }
        public String Nombre { get; set; }

        public String Descripcion { get; set; }

        public bool Activo { get; set; }
        public String Imagen { get; set; }

        public Categoria categoria { get; set; }

        public int Categoria { get; set; }

        public int SubCategoria { get; set; }

        public Producto(int id, string nombre, string descripcion, bool activo, string imagen, int categoria, int subCategoria)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            Activo = activo;
            Imagen = imagen;
            Categoria = categoria;
            SubCategoria = subCategoria;
        }

        public Producto()
        {

        }
        public Producto(string nombre, string descripcion, bool activo, string imagen, int categoria, int subCategoria)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Activo = activo;
            Imagen = imagen;
            Categoria = categoria;
            SubCategoria = subCategoria;
        }
    }
}
