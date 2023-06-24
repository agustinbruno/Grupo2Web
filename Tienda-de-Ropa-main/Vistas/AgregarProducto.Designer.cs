namespace Tienda_de_Ropa.Vistas
{
    partial class AgregarProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarProducto));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Categoria = new System.Windows.Forms.ComboBox();
            this.lbl_error_desc = new System.Windows.Forms.Label();
            this.error_nombre = new System.Windows.Forms.Label();
            this.text_Descripcion = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.btn_crear = new System.Windows.Forms.Button();
            this.label_descripcion = new System.Windows.Forms.Label();
            this.label_nombre = new System.Windows.Forms.Label();
            this.titulo_ABM = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_imagen = new System.Windows.Forms.Label();
            this.txt_path_producto = new System.Windows.Forms.TextBox();
            this.btn_BuscarImagen_producto = new System.Windows.Forms.Button();
            this.label_id = new System.Windows.Forms.Label();
            this.comboBox_SubCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(678, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Categorias";
            // 
            // comboBox_Categoria
            // 
            this.comboBox_Categoria.FormattingEnabled = true;
            this.comboBox_Categoria.Location = new System.Drawing.Point(619, 117);
            this.comboBox_Categoria.Name = "comboBox_Categoria";
            this.comboBox_Categoria.Size = new System.Drawing.Size(179, 21);
            this.comboBox_Categoria.TabIndex = 30;
            this.comboBox_Categoria.SelectedIndexChanged += new System.EventHandler(this.comboBox_Categoria_SelectedIndexChanged);
            // 
            // lbl_error_desc
            // 
            this.lbl_error_desc.AutoSize = true;
            this.lbl_error_desc.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_desc.Location = new System.Drawing.Point(446, 174);
            this.lbl_error_desc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_error_desc.Name = "lbl_error_desc";
            this.lbl_error_desc.Size = new System.Drawing.Size(85, 13);
            this.lbl_error_desc.TabIndex = 28;
            this.lbl_error_desc.Text = "error descripcion";
            // 
            // error_nombre
            // 
            this.error_nombre.AutoSize = true;
            this.error_nombre.ForeColor = System.Drawing.Color.Red;
            this.error_nombre.Location = new System.Drawing.Point(446, 137);
            this.error_nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.error_nombre.Name = "error_nombre";
            this.error_nombre.Size = new System.Drawing.Size(69, 13);
            this.error_nombre.TabIndex = 27;
            this.error_nombre.Text = "error nombre ";
            // 
            // text_Descripcion
            // 
            this.text_Descripcion.Location = new System.Drawing.Point(216, 174);
            this.text_Descripcion.Margin = new System.Windows.Forms.Padding(2);
            this.text_Descripcion.Name = "text_Descripcion";
            this.text_Descripcion.Size = new System.Drawing.Size(184, 20);
            this.text_Descripcion.TabIndex = 25;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(216, 135);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(184, 20);
            this.txt_nombre.TabIndex = 24;
            // 
            // btn_crear
            // 
            this.btn_crear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(65)))), ((int)(((byte)(147)))));
            this.btn_crear.FlatAppearance.BorderSize = 0;
            this.btn_crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_crear.Location = new System.Drawing.Point(241, 282);
            this.btn_crear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(120, 51);
            this.btn_crear.TabIndex = 23;
            this.btn_crear.Text = "Crear producto";
            this.btn_crear.UseVisualStyleBackColor = false;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // label_descripcion
            // 
            this.label_descripcion.AutoSize = true;
            this.label_descripcion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_descripcion.Location = new System.Drawing.Point(75, 178);
            this.label_descripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_descripcion.Name = "label_descripcion";
            this.label_descripcion.Size = new System.Drawing.Size(61, 13);
            this.label_descripcion.TabIndex = 21;
            this.label_descripcion.Text = "descripcion";
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_nombre.Location = new System.Drawing.Point(75, 139);
            this.label_nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(42, 13);
            this.label_nombre.TabIndex = 20;
            this.label_nombre.Text = "nombre";
            // 
            // titulo_ABM
            // 
            this.titulo_ABM.AutoSize = true;
            this.titulo_ABM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titulo_ABM.Location = new System.Drawing.Point(213, 89);
            this.titulo_ABM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titulo_ABM.Name = "titulo_ABM";
            this.titulo_ABM.Size = new System.Drawing.Size(184, 13);
            this.titulo_ABM.TabIndex = 19;
            this.titulo_ABM.Text = "Alta, Baja y Modificacion de Producto";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(871, 7);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(20, 20);
            this.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_cerrar.TabIndex = 8;
            this.btn_cerrar.TabStop = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(44)))), ((int)(((byte)(127)))));
            this.panel2.Controls.Add(this.btn_cerrar);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 30);
            this.panel2.TabIndex = 34;
            // 
            // label_imagen
            // 
            this.label_imagen.AutoSize = true;
            this.label_imagen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_imagen.Location = new System.Drawing.Point(75, 217);
            this.label_imagen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_imagen.Name = "label_imagen";
            this.label_imagen.Size = new System.Drawing.Size(41, 13);
            this.label_imagen.TabIndex = 35;
            this.label_imagen.Text = "imagen";
            // 
            // txt_path_producto
            // 
            this.txt_path_producto.Location = new System.Drawing.Point(216, 217);
            this.txt_path_producto.Margin = new System.Windows.Forms.Padding(2);
            this.txt_path_producto.Name = "txt_path_producto";
            this.txt_path_producto.Size = new System.Drawing.Size(184, 20);
            this.txt_path_producto.TabIndex = 36;
            // 
            // btn_BuscarImagen_producto
            // 
            this.btn_BuscarImagen_producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(65)))), ((int)(((byte)(147)))));
            this.btn_BuscarImagen_producto.FlatAppearance.BorderSize = 0;
            this.btn_BuscarImagen_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BuscarImagen_producto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_BuscarImagen_producto.Location = new System.Drawing.Point(449, 214);
            this.btn_BuscarImagen_producto.Margin = new System.Windows.Forms.Padding(5);
            this.btn_BuscarImagen_producto.Name = "btn_BuscarImagen_producto";
            this.btn_BuscarImagen_producto.Size = new System.Drawing.Size(82, 24);
            this.btn_BuscarImagen_producto.TabIndex = 37;
            this.btn_BuscarImagen_producto.Text = "Buscar";
            this.btn_BuscarImagen_producto.UseVisualStyleBackColor = false;
            this.btn_BuscarImagen_producto.Click += new System.EventHandler(this.btn_BuscarImagen_producto_Click);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(133, 139);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(15, 13);
            this.label_id.TabIndex = 38;
            this.label_id.Text = "id";
            // 
            // comboBox_SubCategoria
            // 
            this.comboBox_SubCategoria.FormattingEnabled = true;
            this.comboBox_SubCategoria.Location = new System.Drawing.Point(619, 192);
            this.comboBox_SubCategoria.Name = "comboBox_SubCategoria";
            this.comboBox_SubCategoria.Size = new System.Drawing.Size(179, 21);
            this.comboBox_SubCategoria.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(678, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "SubCategoria";
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(123)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(900, 401);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_SubCategoria);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.btn_BuscarImagen_producto);
            this.Controls.Add(this.txt_path_producto);
            this.Controls.Add(this.label_imagen);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Categoria);
            this.Controls.Add(this.lbl_error_desc);
            this.Controls.Add(this.error_nombre);
            this.Controls.Add(this.text_Descripcion);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.label_descripcion);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.titulo_ABM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarProducto";
            this.Text = "AgregarProducto";
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Categoria;
        private System.Windows.Forms.Label lbl_error_desc;
        private System.Windows.Forms.Label error_nombre;
        private System.Windows.Forms.TextBox text_Descripcion;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.Label label_descripcion;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.Label titulo_ABM;
        private System.Windows.Forms.PictureBox btn_cerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_imagen;
        private System.Windows.Forms.TextBox txt_path_producto;
        private System.Windows.Forms.Button btn_BuscarImagen_producto;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.ComboBox comboBox_SubCategoria;
        private System.Windows.Forms.Label label2;
    }
}