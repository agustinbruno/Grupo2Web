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
    public partial class AgregarProducto : Form

    {
        public string situacion;



        public AgregarProducto()
        {
            InitializeComponent();
            error_nombre.Hide();
            lbl_error_desc.Hide();
            this.StartPosition = FormStartPosition.CenterScreen;
            llenarCombosCategoria();
            situacion = "crear";
            label_id.Hide();
            llenarCombosSubCategoria();


        }

        public AgregarProducto(Producto prod)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            error_nombre.Hide();
            lbl_error_desc.Hide();
            label_id.Text = prod.Id.ToString();
            label_id.Hide();
            text_Descripcion.Text = prod.Descripcion;
            txt_nombre.Text = prod.Nombre;      
            btn_crear.Text = "Actualizar producto";
            situacion = "editar";
            txt_path_producto.Text = prod.Imagen;
            comboBox_Categoria.Text = Categoria_Controller.obtenerNombreCategoria(prod.Categoria);
            comboBox_SubCategoria.Text = Categoria_Controller.obtenerNombreCategoria(prod.SubCategoria);
            llenarCombosCategoria();
            llenarCombosSubCategoria();

        }

        private void llenarCombosCategoria()
        {
            List<Categoria> ListCat = Categoria_Controller.obtenerTodos();
            comboBox_Categoria.Items.Clear();
            foreach (Categoria cat in ListCat)
            {
                comboBox_Categoria.Items.Add(cat.Nombre);
            }
        }

        private void llenarCombosSubCategoria()
        {
            if (comboBox_Categoria.Text != null)
            {
                int idPadre = Categoria_Controller.obtenerIdCategoria(comboBox_Categoria.Text);
                List<Categoria> ListCat = Categoria_Controller.obtenerSubcategoria(idPadre);
                comboBox_SubCategoria.Items.Clear();
                foreach (Categoria cat in ListCat)
                {
                    comboBox_SubCategoria.Items.Add(cat.Nombre);
                }
            }      
        }


        private void btn_crear_Click(object sender, EventArgs e)
        {
            int categoria = Categoria_Controller.obtenerIdCategoria(comboBox_Categoria.Text);
            int subcategoria = Categoria_Controller.obtenerIdCategoria(comboBox_SubCategoria.Text);
            if (situacion == "crear")
            {
                bool inputsValidos = validarInputs(out String ErrorMsg);
                Trace.WriteLine("inputs validados con resultado: " + inputsValidos);

                if (inputsValidos)
                {
                    Producto prod = new Producto(txt_nombre.Text, text_Descripcion.Text, true, txt_path_producto.Text, categoria, subcategoria);

                    if (Producto_Controlller.crearProducto(prod))
                    {   
                        Trace.WriteLine("Producto Creado con exito");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        Trace.WriteLine("Fallo la creacion del producto");
                    }
                }
                else
                {
                    Trace.WriteLine("Inputs invalidos");
                }
            }
            else
            {
                
                if (Producto_Controlller.editarProductos(new Producto(int.Parse(label_id.Text),txt_nombre.Text, text_Descripcion.Text, true, txt_path_producto.Text,categoria,subcategoria)))
                {
                    Trace.WriteLine("Producto Actualizado con exito");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {                
                    Trace.WriteLine("Fallo la actualizacion del producto");
                }

            }
        }


        private bool validarInputs(out string errorMsg)
        {
            errorMsg = String.Empty;

            if (string.IsNullOrEmpty(txt_nombre.Text))
            {
                errorMsg += "Debe indicar el nombre del producto. " + Environment.NewLine;
                error_nombre.Text = "Debe indicar el nombre del producto";
                error_nombre.Show();
            }
            if (string.IsNullOrEmpty(text_Descripcion.Text))
            {
                errorMsg += "De indicar la descripcion del producto. " + Environment.NewLine;
                lbl_error_desc.Text = "Debe indicar la descripcion del producto. ";
                lbl_error_desc.Show();
            }
            return errorMsg == String.Empty;
        }
        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {
            error_nombre.Hide();
            validarInputs(out string errorMsg);
        }

        private void text_Descripcion_TextChanged(object sender, EventArgs e)
        {
            lbl_error_desc.Hide();
            validarInputs(out string errorMsg);
        }

        private void text_Id_TextChanged(object sender, EventArgs e)
        {

            validarInputs(out string errorMsg);
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_BuscarImagen_producto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog folderBrowserDialog = new OpenFileDialog() { Multiselect = false, ValidateNames = true, Filter = "Archivos de imagen|*.bmp;*.jpg;*.jpeg;*.png;*.gif" })
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    txt_path_producto.Text = folderBrowserDialog.FileName;
                }
            }
        }

        private void comboBox_Categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarCombosSubCategoria();
            comboBox_SubCategoria.Text = "";
        }
    }
}
