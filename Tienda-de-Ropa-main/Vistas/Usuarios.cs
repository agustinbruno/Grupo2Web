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
    public partial class Usuarios : Form
    {
        List<Empleado> empleados;
        
        
        public Usuarios()
        {
            
            InitializeComponent();
            mostrarEmpleados();
            if (!Usuario_Controller.verificarPermisos())
            {
                txt_agregar_usuario.Hide();
                txt_eliminar_usuario.Hide();
            }                 
            
        }
        private void mostrarEmpleados()
        {
            
            empleados = Usuario_Controller.obtenerTodos();
            tablaUsuarios.Rows.Clear();
            foreach (Empleado empleado in empleados)
            {
                Image imagen = Image.FromFile(empleado.Imagen);
                int rowIndex = tablaUsuarios.Rows.Add();

                tablaUsuarios.Rows[rowIndex].Height = 150;

                tablaUsuarios.Rows[rowIndex].Cells[0].Value = empleado.Id.ToString();
                tablaUsuarios.Rows[rowIndex].Cells[1].Value = empleado.Usuario.ToString();
                tablaUsuarios.Rows[rowIndex].Cells[2].Value = empleado.Nombre.ToString();
                tablaUsuarios.Rows[rowIndex].Cells[3].Value = empleado.Rol.ToString();
                tablaUsuarios.Rows[rowIndex].Cells[4].Value = imagen;

            }

        }

        private void txt_agregar_usuario_Click(object sender, EventArgs e)
        {
            AgregarUsuarios agregarUsuarios = new AgregarUsuarios();
            DialogResult dialogResult = agregarUsuarios.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                Trace.WriteLine("OK");
                
            }
        }

        private void txt_eliminar_usuario_Click(object sender, EventArgs e)
        {
            EliminarUsuarios eliminarUsuarios = new EliminarUsuarios();
            DialogResult dialogResult = eliminarUsuarios.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                Trace.WriteLine("OK");

            }
        }
    }
}
