using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tienda_de_Ropa.Controladores;
using Tienda_de_Ropa.Modelos;
using Tienda_de_Ropa.Vistas;

namespace Tienda_de_Ropa.UserControls
{
    public partial class ProductosControls : UserControl
    {
        List<Producto> productos;
        public ProductosControls()
        {
            InitializeComponent();
            mostrarProductos();
        }

        private void mostrarProductos()
        {
            productos = Producto_Controlller.obtenerTodos();
            tablaProductos.Rows.Clear();
            

            foreach (Producto prod in productos)
            {


                int rowIndex = tablaProductos.Rows.Add();
                Image imagen = Image.FromFile(prod.Imagen);
                tablaProductos.Rows[rowIndex].Cells[0].Value = prod.Id.ToString();
                tablaProductos.Rows[rowIndex].Cells[1].Value = prod.Nombre.ToString();
                tablaProductos.Rows[rowIndex].Cells[2].Value = prod.Descripcion.ToString();              
                tablaProductos.Rows[rowIndex].Cells[3].Value = prod.Activo.ToString();
                tablaProductos.Rows[rowIndex].Cells[4].Value = Categoria_Controller.obtenerNombreCategoria(prod.Categoria).ToString();
                tablaProductos.Rows[rowIndex].Cells[5].Value = Categoria_Controller.obtenerNombreCategoria(prod.SubCategoria).ToString();
                tablaProductos.Rows[rowIndex].Cells[8].Value = imagen;

                if (prod.Activo)
                {
                    tablaProductos.Rows[rowIndex].Cells[6].Value = "Desactivar";
                }
                else
                {
                    tablaProductos.Rows[rowIndex].Cells[6].Value = "Activar";
                }
                tablaProductos.Rows[rowIndex].Cells[7].Value = "Editar";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarProducto form1 = new AgregarProducto();

            DialogResult dialogoResult = form1.ShowDialog();

            if (dialogoResult == DialogResult.OK)
            {
                mostrarProductos();
            }
        }

        private void tablaProductos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;


            int id = int.Parse(tablaProductos.Rows[e.RowIndex].Cells[0].Value.ToString());
            Trace.WriteLine(id);
            Trace.WriteLine(senderGrid.Columns[e.ColumnIndex].Name);
            Trace.WriteLine(e.RowIndex);

            if (senderGrid.Columns[e.ColumnIndex].Name == "Acciones" && e.RowIndex >= 0)
            {
                string estado = tablaProductos.Rows[e.RowIndex].Cells[3].Value.ToString();
                Trace.WriteLine(estado);
                if (estado == "True")
                {
                    Producto_Controlller.cambiarEstado(id, 0);
                }
                else
                {
                    Producto_Controlller.cambiarEstado(id, 1);
                }
                mostrarProductos();
            }

            if (senderGrid.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
            {

                Producto prodEditar = Producto_Controlller.obtenerProducto(id);
                AgregarProducto form1 = new AgregarProducto(prodEditar);

                DialogResult dialogoResult = form1.ShowDialog();

                if (dialogoResult == DialogResult.OK)
                {
                    mostrarProductos();
                }
            }
        }
    }
}
