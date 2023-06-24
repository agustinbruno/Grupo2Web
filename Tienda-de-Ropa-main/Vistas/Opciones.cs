using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tienda_de_Ropa.Controladores;
using Tienda_de_Ropa.Modelos;
using Tienda_de_Ropa.Modelos.Enums;

namespace Tienda_de_Ropa.Vistas
{
    public partial class Opciones : Form
    {
        Empleado emp = Usuario_Controller.obtenerEmpleadoLogeado();
        public Opciones()
        {
            InitializeComponent();
            lbl_errorOpciones.Hide();
            pictureBox_Opciones.Image = Image.FromFile(emp.Imagen);
            txt_Contraseña.UseSystemPasswordChar = true;
            if (emp.Rol == (int)Rol.Admin)
            {
                label_Rol.Text = "Admin";
            }
            else
            {
                label_Rol.Text = "Vendedor";
            }
                
            txt_Contraseña.Text = emp.Contraseña;
            txt_Nombre.Text = emp.Nombre;
            txt_Correo.Text = emp.Email;
        }

        private void button_CambiarFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog folderBrowserDialog = new OpenFileDialog() { Multiselect = false, ValidateNames = true, Filter = "Archivos de imagen|*.bmp;*.jpg;*.jpeg;*.png;*.gif" })
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    emp.Imagen = folderBrowserDialog.FileName;
                    pictureBox_Opciones.Image = Image.FromFile(emp.Imagen);
                }
            }
        }
        private void button_Guardar_Click_1(object sender, EventArgs e)
        {

            if (validarInputsOpciones())
            {
                if (Usuario_Controller.actualizarDatosUsuario(emp.Usuario, txt_Nombre.Text, txt_Contraseña.Text, emp.Imagen,txt_Correo.Text))
                {
                    MessageBox.Show("Datos Actualizados");
                }
                else
                {
                    MessageBox.Show("Error al actualizar los datos");
                }
            }

        }

        private bool validarInputsOpciones()
        {

            if (string.IsNullOrEmpty(txt_Nombre.Text) || string.IsNullOrEmpty(txt_Contraseña.Text))
            {
                lbl_errorOpciones.Text = "Alguno de los campos esta vacio";
                lbl_errorOpciones.Show();
                return false;
            }
            else
            {
                return true;
            }
           
        }
    }
}
