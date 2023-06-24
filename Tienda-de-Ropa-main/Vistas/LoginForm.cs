using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Tienda_de_Ropa.Controladores;
using Tienda_de_Ropa.Modelos;

namespace Tienda_de_Ropa.Vistas
{
    public partial class LoginForm : Form
    {    
        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            lbl_error_login.Hide();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_usuario.Clear();
            txt_contraseña.Clear();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (validarInputsLogin())
            {
                Trace.WriteLine("Contraseña correcta");
                
                Usuario_Controller.empleadoSessionStart(txt_usuario.Text);
                Index index = new Index();
                this.Hide();
                index.Show();
            }
        }

        private bool validarInputsLogin()
        {

            if (string.IsNullOrEmpty(txt_usuario.Text) || string.IsNullOrEmpty(txt_contraseña.Text) || txt_contraseña.Text=="Contraseña" || txt_usuario.Text=="Usuario")
            {
                lbl_error_login.Text = "Alguno de los campos esta vacio";
                lbl_error_login.Show();
                return false;
            }
            else if (Usuario_Controller.validarUsuario(txt_usuario.Text, txt_contraseña.Text))
            {              
                return true;
            }
            else
            {
                lbl_error_login.Text = "Usuario y/o contraseña incorrecto";
                lbl_error_login.Show();
                return false;
            }          
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_usuario_Enter(object sender, EventArgs e)
        {
            if(txt_usuario.Text == "Usuario")
            {
                txt_usuario.Text = "";
                txt_usuario.ForeColor = Color.Black;
            }
        }

        private void txt_usuario_Leave(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "")
            {
                txt_usuario.Text = "Usuario";
                txt_usuario.ForeColor = Color.Black;
            }
        }

        private void txt_contraseña_Enter(object sender, EventArgs e)
        {
            if (txt_contraseña.Text == "Contraseña")
            {
                txt_contraseña.Text = "";
                txt_contraseña.ForeColor = Color.Black;
                txt_contraseña.UseSystemPasswordChar = true;
            }
        }

        private void txt_contraseña_Leave(object sender, EventArgs e)
        {
            if (txt_contraseña.Text == "")
            {
                txt_contraseña.Text = "Contraseña";
                txt_contraseña.ForeColor = Color.Black;
                txt_contraseña.UseSystemPasswordChar = false;

            }
        }

        private void txt_contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                btn_login_Click(sender, e);
            }
            
        }

        private void txt_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_login_Click(sender, e);
            }
        }
    }
}
