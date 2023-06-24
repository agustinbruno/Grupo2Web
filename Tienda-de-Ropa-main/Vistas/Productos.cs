using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tienda_de_Ropa.Modelos;
using Tienda_de_Ropa.UserControls;

namespace Tienda_de_Ropa.Vistas
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
            ProductosControls productos = new ProductosControls();
            adduserControl(productos);

        }

        private void btn_cats_Click(object sender, EventArgs e)
        {
            CategoriasControls categorias = new CategoriasControls();
            adduserControl(categorias);
        }

        private void btn_prods_Click(object sender, EventArgs e)
        {
            ProductosControls productos = new ProductosControls();
            adduserControl(productos);
        }
        private void adduserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        
    }
}
