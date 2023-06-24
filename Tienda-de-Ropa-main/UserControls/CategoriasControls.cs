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
using Tienda_de_Ropa.Vistas;

namespace Tienda_de_Ropa.UserControls
{
    public partial class CategoriasControls : UserControl
    {
        List<Categoria> categorias;
        public CategoriasControls()
        {
            InitializeComponent();
            llenarDGV();
            if (!Usuario_Controller.verificarPermisos())
            {
                btn_new.Hide();          
            }
        }

        private void mostrarCategorias(List<Categoria> categorias, string orden)
        {
            foreach (Categoria cat in categorias)
            {
                int rowIndex = panelCategorias.Rows.Add();

                panelCategorias.Rows[rowIndex].Cells[0].Value = cat.Id.ToString();
                panelCategorias.Rows[rowIndex].Cells[1].Value = orden + " " + cat.Nombre.ToString();
                panelCategorias.Rows[rowIndex].Cells[3].Value = orden + " " + cat.Activo.ToString();

                if (cat.Activo)
                {
                    panelCategorias.Rows[rowIndex].Cells[4].Value = "Desactivar";
                }
                else
                {
                    panelCategorias.Rows[rowIndex].Cells[4].Value = "Activar";
                }

                panelCategorias.Rows[rowIndex].Cells[5].Value = "Editar";

                if (cat.subcategorias != null)
                {
                    mostrarCategorias(cat.subcategorias, orden + "Hijo_");
                }
            }
        }

        private void llenarDGV()
        {
            categorias = Categoria_Controller.obtenerTodos();
            panelCategorias.Rows.Clear();
            mostrarCategorias(categorias, "");
        }

        private void panelCategorias_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            int id = int.Parse(panelCategorias.Rows[e.RowIndex].Cells[0].Value.ToString()); //me guardo el id
            Trace.WriteLine(id);

            if (senderGrid.Columns[e.ColumnIndex].Name == "Acciones" && e.RowIndex >= 0)
            {
                string estado = panelCategorias.Rows[e.RowIndex].Cells[3].Value.ToString();

                if (estado.Contains("True"))
                {                 
                    Categoria_Controller.cambiarEstado(id, 0);
                }
                else
                {
                    Categoria_Controller.cambiarEstado(id, 1);
                }
                llenarDGV();


            }

            if (senderGrid.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
            {
                //Editemos
                Categoria catEditar = Categoria_Controller.obtenerCategoria(id);

                AgregarCategoria FormCats = new AgregarCategoria(catEditar);

                DialogResult dialogoResult = FormCats.ShowDialog();

                if (dialogoResult == DialogResult.OK)
                {
                    llenarDGV();
                }
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            //var cat_cat = Categoria_Controlador.obtenerCategoria(id);

            AgregarCategoria FormCats = new AgregarCategoria();

            DialogResult dialogoResult = FormCats.ShowDialog();

            if (dialogoResult == DialogResult.OK)
            {
                Trace.WriteLine("OK");
                llenarDGV();
            }
        }
    }
}
