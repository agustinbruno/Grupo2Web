using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_de_Ropa.Modelos
{
    public class Categoria
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public int Padre { get; set; }

        public List<Categoria> subcategorias { get; set; }
        public bool Activo { get; set; }

        public Categoria(string nombre,int padre,bool activo)
        {
            Nombre = nombre;
            Padre = padre;
            Activo = activo;
        }

        public Categoria()
        {

        }
    }
}
