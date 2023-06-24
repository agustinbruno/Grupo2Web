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

namespace Tienda_de_Ropa.Vistas
{
    public partial class AgregarCategoria : Form
    {
        public AgregarCategoria()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            comboBox_PadreCat.Hide();
            lbl_PadreCat.Hide();
            llenarCombosCategoria();
        }

        private void llenarCombosCategoria()
        {
            List<Categoria> ListCat = Categoria_Controller.obtenerTodos();
            comboBox_PadreCat.Items.Clear();
            foreach (Categoria cat in ListCat)
            {
                comboBox_PadreCat.Items.Add(cat.Nombre);
            }
        }

        public AgregarCategoria(Categoria cat)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_AgregarCat_Click(object sender, EventArgs e)
        {
            
            if(button_Switch.Text == "Categoria")
            {
                Categoria categoria = new Categoria(txt_NombreCat.Text, -1, true);
                Categoria_Controller.crearCategoria(categoria);
                MessageBox.Show("Categoria creada");
            }
            else
            {
                Categoria categoria = new Categoria(txt_NombreCat.Text, Categoria_Controller.obtenerIdCategoria(comboBox_PadreCat.Text), true);
                Categoria_Controller.crearCategoria(categoria);
                MessageBox.Show("SubCategoria creada");
            }
            
            this.Close();
            
        }

        private void button_Switch_Click(object sender, EventArgs e)
        {
            if(button_Switch.Text == "Categoria")
            {
                lbl_PadreCat.Show();
                comboBox_PadreCat.Show();
                button_Switch.Text = "Subcategoria";
            }
            else
            {
                comboBox_PadreCat.Hide();
                lbl_PadreCat.Hide();
                button_Switch.Text = "Categoria";
                
            }
        }
    }
}
