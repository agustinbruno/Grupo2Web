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
    public partial class Index : Form
    {
        Empleado emp = Usuario_Controller.obtenerEmpleadoLogeado();
        public Index()
        {      
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            if (Usuario_Controller.verificarPermisos())
            {             
                label_rol.Text = "Admin";

            }
            else
            {
                label_rol.Text = "Vendedor";
            }
            label_name.Text = emp.Nombre;
            pictureBox_Index.Image = Image.FromFile(@emp.Imagen);
        }    
        private void btn_producto_Click(object sender, EventArgs e)
        {
            AgregarProducto form1 = new AgregarProducto();
            this.Hide();
            form1.ShowDialog();
        }
        private void abrirFormInPanel(object formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0) 
                this.panelContenedor.Controls.RemoveAt(0);          
                Form fh = formhijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panelContenedor.Controls.Add(fh);
                this.panelContenedor.Tag = fh;
                fh.Show();
            
        }

        private void button_Estadisticas_Click(object sender, EventArgs e)
        {
            
        }

        private void button_Usuarios_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new Usuarios());
        }

        private void button_Productos_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new Productos());
        }

        private void button_LogOut_Click(object sender, EventArgs e)
        {
            Usuario_Controller.empleadoSessionClose();
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btn_minimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Opciones_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new Opciones());
        }

    }
}