using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Tienda_de_Ropa.Modelos;
using Tienda_de_Ropa.Modelos.Enums;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Tienda_de_Ropa.Controladores
{
    internal class Usuario_Controller
    {
        private static Empleado currentSessionEmpleado;
        public static void empleadoSessionStart(string usuario)
        {
            currentSessionEmpleado = new Empleado(usuario);
        }

        public static void empleadoSessionClose()
        {
            currentSessionEmpleado = null;
        }


        public static bool validarUsuario(string usuario, string contraseña){

            string query = "SELECT COUNT(*) FROM empleado WHERE usuario = @usuario AND contraseña = @contraseña";
            SqlCommand cmd = new SqlCommand (query,DB_Controller.connection);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@contraseña", contraseña);
            try
            {

                DB_Controller.connection.Open();
                int count = (int)cmd.ExecuteScalar();
                DB_Controller.connection.Close();

                if (count > 0) {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Empleado obtenerEmpleadoLogeado()
        {
            string usuario = currentSessionEmpleado.Usuario;
            string query = "SELECT * FROM empleado WHERE usuario = @usuario";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            try
            {
                Empleado emp = null;
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    emp = new Empleado(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetString(5),reader.GetString(6));
                }

                reader.Close();
                DB_Controller.connection.Close();

                return emp;
            }
            catch (Exception ex)
            {
                DB_Controller.connection.Close();
                throw new Exception(ex.Message);
            }          
        }

        public static List<Empleado> obtenerTodos()
        {
            List<Empleado> list = new List<Empleado>();
            string query = "select * from dbo.empleado";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Empleado(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),reader.GetInt32(4),reader.GetString(5), reader.GetString(6)));
                    Trace.WriteLine("Empleado encontrado, Usuario: " + reader.GetString(2));
                }
                reader.Close();
                DB_Controller.connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }
            return list;
        }


        public static bool verificarPermisos()
        {
            Empleado emp = obtenerEmpleadoLogeado();

            if (emp.Rol == (int)Rol.Admin)
            {
                return true;
            }
            
            return false;
        }


        public static bool actualizarDatosUsuario(string usuario, string nombre, string contraseña, string imagen,string email)
        {
            string query = "update dbo.empleado" +
                " set nombre = @nombre," +
                " contraseña = @contraseña," +
                " imagen = @imagen," +
                " email = @email" +
                " where usuario = @usuario;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@contraseña", contraseña);
            cmd.Parameters.AddWithValue("@imagen", imagen);
            cmd.Parameters.AddWithValue("@email", email);
            try
            {
                DB_Controller.connection.Open();
                cmd.ExecuteNonQuery();
                DB_Controller.connection.Close();
                return true;

            }
            catch (Exception ex)
            {
                DB_Controller.connection.Close();
                Trace.WriteLine("Ocurrio un error al intentar crear el usuario: " + ex.Message);
                return false;
            }
        }

        public static bool crearEmpleado(Empleado empleado)
        {
            string query = "insert into dbo.empleado values" +
                "(@nombre, " +
                "@usuario, " +
                "@contraseña, " +
                "@rol, " +
                "@imagen, " +
                "@email " +
                ");";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@nombre", empleado.Nombre);
            cmd.Parameters.AddWithValue("@usuario", empleado.Usuario);
            cmd.Parameters.AddWithValue("@contraseña", empleado.Contraseña);
            cmd.Parameters.AddWithValue("@rol", empleado.Rol);
            cmd.Parameters.AddWithValue("@imagen", empleado.Imagen);
            cmd.Parameters.AddWithValue("@email", empleado.Email);

            try
            {
                DB_Controller.connection.Open();
                cmd.ExecuteNonQuery();
                DB_Controller.connection.Close();
                return true;

            }
            catch (Exception ex)
            {
                DB_Controller.connection.Close();
                Trace.WriteLine("Ocurrio un error al intentar crear el usuario: " + ex.Message);
                return false;
            }
        }
    }
}
