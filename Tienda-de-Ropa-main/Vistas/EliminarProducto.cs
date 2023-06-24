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
using Tienda_de_Ropa.Modelos;

namespace Tienda_de_Ropa.Vistas
{
    public partial class EliminarProducto : Form
    {
        public EliminarProducto()
        {
            InitializeComponent();
            error_id.Hide();
            error_nombre.Hide();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private bool validarInputs(out string errorMsg)
        {
            errorMsg = string.Empty;

            if (string.IsNullOrEmpty(txt_nombre.Text))
            {
                errorMsg = "Debe indicar el nombre del producto" + Environment.NewLine;
                error_nombre.Text = "Debe indicar el nombre del producto";
                error_nombre.Show();
            }
            if (string.IsNullOrEmpty(txt_id.Text))
            {
                errorMsg = "Debe indicar el id del producto" + Environment.NewLine;
                error_id.Text = "Debe indicar el id del producto";
                error_id.Show();
            }
            return errorMsg == string.Empty;

        }

        private void btn_eliminar_producto_Click(object sender, EventArgs e)
        {

            bool inputsValidos = validarInputs(out string errorMsg);

            Trace.WriteLine("inputs validados con resultado: " + inputsValidos);


            if (inputsValidos)
            {

                string query = "DELETE FROM dbo.producto WHERE ID= @ID AND Nombre = @Nombre";


                try
                {
                    DB_Controller.connection.Open();
                    SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
                    cmd.Parameters.AddWithValue("@ID", txt_id.Text);
                    cmd.Parameters.AddWithValue("@Nombre", txt_nombre.Text);
                    cmd.ExecuteNonQuery();
                    DB_Controller.connection.Close();
                    MessageBox.Show("Producto eliminado con exito");
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

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
