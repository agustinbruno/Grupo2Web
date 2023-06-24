using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tienda_de_Ropa.Controladores;

namespace Tienda_de_Ropa.Vistas
{
    public partial class EliminarUsuarios : Form
    {
        public EliminarUsuarios()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            lbl_error_usuario_eliminar_usuarios.Hide();
            lbl_error_id_eliminar_usuarios.Hide();
        }
        private bool validarInputs(out string errorMsg)
        {
            errorMsg = string.Empty;

            if (string.IsNullOrEmpty(txt_id_eliminar_usuarios.Text))
            {
                errorMsg = "Debe indicar el id del usuario a eliminar" + Environment.NewLine;
                lbl_error_id_eliminar_usuarios.Text = "Debe indicar el id del usuario a eliminar";
                lbl_error_id_eliminar_usuarios.Show();
            }
            if (string.IsNullOrEmpty(txt_usuario_eliminar_usuarios.Text))
            {
                errorMsg = "Debe indicar el usuario a eliminar" + Environment.NewLine;
                lbl_error_usuario_eliminar_usuarios.Text = "Debe indicar el usuario a eliminar";
                lbl_error_usuario_eliminar_usuarios.Show();
            }
            return errorMsg == string.Empty;
        }

        private void btn_eliminar_usuarios_Click(object sender, EventArgs e)
        {
            bool inputsValidos = validarInputs(out string errorMsg);
            Trace.WriteLine("inputs validados con resultado: " + inputsValidos);

            if (inputsValidos)
            {
                string query = "DELETE FROM dbo.empleado WHERE ID= @ID AND Usuario = @usuario";

                try
                {
                    DB_Controller.connection.Open();
                    SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
                    cmd.Parameters.AddWithValue("@ID", txt_id_eliminar_usuarios.Text);
                    cmd.Parameters.AddWithValue("@Usuario", txt_usuario_eliminar_usuarios.Text);
                    cmd.ExecuteNonQuery();
                    DB_Controller.connection.Close();
                    MessageBox.Show("Usuario eliminado con exito");
                    EliminarProducto eliminarProducto = new EliminarProducto();
                    this.Hide();
                    eliminarProducto.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            else
            {
                Trace.WriteLine("Fallo la eliminacion del producto");
            }
        }
        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
