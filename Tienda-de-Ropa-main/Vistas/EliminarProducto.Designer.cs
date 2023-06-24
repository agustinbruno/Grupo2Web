namespace Tienda_de_Ropa.Vistas
{
    partial class EliminarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarProducto));
            this.lbl_baja_de_productos = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.error_id = new System.Windows.Forms.Label();
            this.error_nombre = new System.Windows.Forms.Label();
            this.btn_eliminar_producto = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_cerrar = new System.Windows.Forms.PictureBox();
            this.btn_atras = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_baja_de_productos
            // 
            this.lbl_baja_de_productos.AutoSize = true;
            this.lbl_baja_de_productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_baja_de_productos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_baja_de_productos.Location = new System.Drawing.Point(151, 61);
            this.lbl_baja_de_productos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_baja_de_productos.Name = "lbl_baja_de_productos";
            this.lbl_baja_de_productos.Size = new System.Drawing.Size(299, 39);
            this.lbl_baja_de_productos.TabIndex = 0;
            this.lbl_baja_de_productos.Text = "Baja de Productos";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(203, 145);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(193, 27);
            this.txt_id.TabIndex = 1;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.lbl_id.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_id.Location = new System.Drawing.Point(115, 150);
            this.lbl_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(26, 20);
            this.lbl_id.TabIndex = 2;
            this.lbl_id.Text = "ID";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(206, 218);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(193, 27);
            this.txt_nombre.TabIndex = 3;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.lbl_nombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_nombre.Location = new System.Drawing.Point(115, 224);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(68, 20);
            this.lbl_nombre.TabIndex = 4;
            this.lbl_nombre.Text = "Nombre";
            // 
            // error_id
            // 
            this.error_id.AutoSize = true;
            this.error_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.error_id.ForeColor = System.Drawing.Color.Red;
            this.error_id.Location = new System.Drawing.Point(446, 150);
            this.error_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.error_id.Name = "error_id";
            this.error_id.Size = new System.Drawing.Size(71, 20);
            this.error_id.TabIndex = 7;
            this.error_id.Text = "*Error Id";
            // 
            // error_nombre
            // 
            this.error_nombre.AutoSize = true;
            this.error_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.error_nombre.ForeColor = System.Drawing.Color.Red;
            this.error_nombre.Location = new System.Drawing.Point(446, 224);
            this.error_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.error_nombre.Name = "error_nombre";
            this.error_nombre.Size = new System.Drawing.Size(117, 20);
            this.error_nombre.TabIndex = 8;
            this.error_nombre.Text = "*Error Nombre";
            // 
            // btn_eliminar_producto
            // 
            this.btn_eliminar_producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(65)))), ((int)(((byte)(147)))));
            this.btn_eliminar_producto.FlatAppearance.BorderSize = 0;
            this.btn_eliminar_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar_producto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_eliminar_producto.Location = new System.Drawing.Point(91, 304);
            this.btn_eliminar_producto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_eliminar_producto.Name = "btn_eliminar_producto";
            this.btn_eliminar_producto.Size = new System.Drawing.Size(164, 47);
            this.btn_eliminar_producto.TabIndex = 10;
            this.btn_eliminar_producto.Text = "Eliminar Producto";
            this.btn_eliminar_producto.UseVisualStyleBackColor = false;
            this.btn_eliminar_producto.Click += new System.EventHandler(this.btn_eliminar_producto_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(44)))), ((int)(((byte)(127)))));
            this.panel2.Controls.Add(this.btn_cerrar);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 30);
            this.panel2.TabIndex = 13;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(568, 6);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(20, 20);
            this.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_cerrar.TabIndex = 8;
            this.btn_cerrar.TabStop = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_atras
            // 
            this.btn_atras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(65)))), ((int)(((byte)(147)))));
            this.btn_atras.FlatAppearance.BorderSize = 0;
            this.btn_atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atras.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_atras.Location = new System.Drawing.Point(316, 304);
            this.btn_atras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(164, 47);
            this.btn_atras.TabIndex = 14;
            this.btn_atras.Text = "Atras";
            this.btn_atras.UseVisualStyleBackColor = false;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // EliminarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(123)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(596, 383);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_eliminar_producto);
            this.Controls.Add(this.error_nombre);
            this.Controls.Add(this.error_id);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_baja_de_productos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EliminarProducto";
            this.Text = "EliminarProducto";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_baja_de_productos;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label error_id;
        private System.Windows.Forms.Label error_nombre;
        private System.Windows.Forms.Button btn_eliminar_producto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btn_cerrar;
        private System.Windows.Forms.Button btn_atras;
    }
}