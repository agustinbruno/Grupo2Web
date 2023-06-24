using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class AgregarUsuarios : Form
    {
        public AgregarUsuarios()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            error_nombre_usuarios.Hide();
            error_usuario_usuarios.Hide();
            error_contraseña_usuarios.Hide();
            error_rol_usuarios.Hide();
            error_email_usuario.Hide();         
        }
        private bool validarInputs(out string errorMsg)
        {
            errorMsg = string.Empty;

            if (string.IsNullOrEmpty(txt_nombre_usuarios.Text))
            {
                errorMsg = "Debe indicar el nombre del producto" + Environment.NewLine;
                error_nombre_usuarios.Text = "Debe indicar el nombre del producto";
                error_nombre_usuarios.Show();
            }
            if (string.IsNullOrEmpty(txt_usuario_usuarios.Text))
            {
                errorMsg = "Debe indicar la descripcion del producto" + Environment.NewLine;
                error_usuario_usuarios.Text = "Debe indicar la descripcion del producto";
                error_usuario_usuarios.Show();
            }
            if (string.IsNullOrEmpty(txt_contraseña_usuarios.Text))
            {
                errorMsg = "Debe indicar el precio del producto" + Environment.NewLine;
                error_contraseña_usuarios.Text = "Debe indicar el precio del producto";
                error_contraseña_usuarios.Show();
            }
            if (string.IsNullOrEmpty(txt_rol_usuarios.Text))
            {
                errorMsg = "Debe indicar el precio del producto" + Environment.NewLine;
                error_rol_usuarios.Text = "Debe indicar el precio del producto";
                error_rol_usuarios.Show();
            }
            return errorMsg == string.Empty;

        }

        private void txt_id_usuarios_KeyPress(object sender, KeyPressEventArgs e)
        {            
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
        }
        private void txt_rol_usuarios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_crear_usuario_Click(object sender, EventArgs e)
        {
            bool inputsValidos = validarInputs(out string errorMsg);

            Trace.WriteLine("inputs validados con resultado: " + inputsValidos);


            if (inputsValidos)
            {
                Empleado empleado = new Empleado(txt_nombre_usuarios.Text, txt_usuario_usuarios.Text, txt_contraseña_usuarios.Text, int.Parse(txt_rol_usuarios.Text), txt_Path_usuarios.Text,txt_Email_usuarios.Text);
                Usuario_Controller.crearEmpleado(empleado);
                
                AgregarUsuarios agregarUsuarios = new AgregarUsuarios();
                this.Hide();
                agregarUsuarios.Close();
                MessageBox.Show("Empleado creado con exito");
            }
            else
            {
                Trace.WriteLine("Fallo la creacion del usuario");
            }
        }

        private void btn_BuscarImagen_usuarios_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog folderBrowserDialog = new OpenFileDialog() { Multiselect = false, ValidateNames = true, Filter = "Archivos de imagen|*.bmp;*.jpg;*.jpeg;*.png;*.gif" })
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    txt_Path_usuarios.Text = folderBrowserDialog.FileName;
                }
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
