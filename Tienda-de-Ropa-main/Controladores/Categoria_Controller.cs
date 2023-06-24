using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda_de_Ropa.Modelos;

namespace Tienda_de_Ropa.Controladores
{
    internal class Categoria_Controller
    {
        static string ruta = "../../Resources/productos.txt";
        public static bool crearCategoria(Categoria cat)
        {
            string query = "insert into dbo.categoria values" +
                "(" +
                "@nombre, " +
                "@padre, " +
                "@activo " +
                ");";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@nombre", cat.Nombre);
            cmd.Parameters.AddWithValue("@padre", cat.Padre);
            cmd.Parameters.AddWithValue("@activo", cat.Activo);

            try
            {   
                DB_Controller.connection.Open();
                cmd.ExecuteNonQuery();
                DB_Controller.connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }
        }

        public static bool cambiarEstado(int id, int estado)
        {
            string query = "update dbo.categoria set activo = @estado where id = @id;";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@estado", estado);


            try
            {   
                DB_Controller.connection.Open();
                cmd.ExecuteNonQuery();
                DB_Controller.connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }
        }

        public static bool editarCategoria(Categoria newCat)
        {
            string query = "update dbo.categoria set nombre = @nombre where id = @id;";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@nombre", newCat.Nombre);
            cmd.Parameters.AddWithValue("@id", newCat.Padre);

            try
            {
                DB_Controller.connection.Open();
                cmd.ExecuteNonQuery();
                DB_Controller.connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }
        }
        public static Categoria obtenerCategoria(int id)
        {
            string query = "select * from dbo.categoria where id = @id";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                Categoria cat = new Categoria();
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cat.Id = reader.GetInt32(0);
                    cat.Nombre = reader.GetString(1);

                    if (reader.GetInt32(2) != -1)
                    {
                        cat.Padre = reader.GetInt32(2);
                    }

                    cat.Activo = reader.GetBoolean(3);
                    cat = new Categoria();
                }
                reader.Close();
                DB_Controller.connection.Close();
                return cat;
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }
        }


        public static string obtenerNombreCategoria(int id)
        {
            string query = "select nombre from dbo.categoria where id = @id";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                string nombre = "";
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    nombre = reader.GetString(0);
 
                }
                reader.Close();
                DB_Controller.connection.Close();
                return nombre;
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }
        }

        public static int obtenerIdCategoria(string nombre)
        {
            string query = "select id from dbo.categoria where nombre = @nombre";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@nombre", nombre);

            try
            {
                int id=0;
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
                reader.Close();
                DB_Controller.connection.Close();
                return id;
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }
        }

        public static List<Categoria> obtenerTodos()
        {

            List<Categoria> list = new List<Categoria>();
            List<Categoria> listaOrdenada = new List<Categoria>();
            List<Categoria> response = new List<Categoria>();
            string query = "select * from dbo.categoria";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Categoria cat = new Categoria();
                    cat.Id = reader.GetInt32(0);
                    cat.Nombre = reader.GetString(1);
                    cat.Padre = reader.GetInt32(2);
                    cat.Activo = reader.GetBoolean(3);

                    if (cat.Padre == -1)
                    {
                        listaOrdenada.Add(cat); // si es -1 es padre y lo guardo listaOrdenada
                    }
                    else
                    {
                        list.Add(cat); // subcategoria lo guarda aca list
                    }
                }

                reader.Close();
                DB_Controller.connection.Close();

                foreach (Categoria cat in listaOrdenada)
                {
                    Categoria catResponse = new Categoria();

                    catResponse.Id = cat.Id;
                    catResponse.Nombre = cat.Nombre;
                    catResponse.Padre = cat.Padre;
                    catResponse.Activo = cat.Activo;
                    catResponse.subcategorias = ordenarCategorias(list, cat);

                    response.Add(catResponse);
                }
                return response;
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }


        }

        public static List<Categoria> obtenerSubcategoria(int id)
        {

            List<Categoria> list = new List<Categoria>();
            string query = "select * from dbo.categoria where padre= @id";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Categoria cat = new Categoria();
                    cat.Id = reader.GetInt32(0);
                    cat.Nombre = reader.GetString(1);
                    cat.Padre = reader.GetInt32(2);
                    cat.Activo = reader.GetBoolean(3);
                
                    list.Add(cat); // subcategoria lo guarda aca list               
                }

                reader.Close();
                DB_Controller.connection.Close();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }


        }

        private static List<Categoria> ordenarCategorias(List<Categoria> list, Categoria catpadre)
        {
            List<Categoria> subcategorias = new List<Categoria>();

            foreach (Categoria cat in list)
            {
                if (catpadre.Id == cat.Padre)
                {
                    subcategorias.Add(cat);

                    if (list.Where(x => x.Padre == cat.Id).Count() > 0)
                    {
                        cat.subcategorias = ordenarCategorias(list, cat);
                    }
                }

            }
            return subcategorias;
        }
    }



}
