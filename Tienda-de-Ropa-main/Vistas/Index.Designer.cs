namespace Tienda_de_Ropa.Vistas
{
    partial class Index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_Datos = new System.Windows.Forms.Panel();
            this.label_name = new System.Windows.Forms.Label();
            this.pictureBox_Index = new System.Windows.Forms.PictureBox();
            this.label_rol = new System.Windows.Forms.Label();
            this.button_Opciones = new System.Windows.Forms.Button();
            this.button_LogOut = new System.Windows.Forms.Button();
            this.button_Usuarios = new System.Windows.Forms.Button();
            this.button_Productos = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_minimizar = new System.Windows.Forms.PictureBox();
            this.btn_cerrar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel_Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Index)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(65)))), ((int)(((byte)(147)))));
            this.panel1.Controls.Add(this.panel_Datos);
            this.panel1.Controls.Add(this.button_Opciones);
            this.panel1.Controls.Add(this.button_LogOut);
            this.panel1.Controls.Add(this.button_Usuarios);
            this.panel1.Controls.Add(this.button_Productos);
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 538);
            this.panel1.TabIndex = 1;
            // 
            // panel_Datos
            // 
            this.panel_Datos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(65)))), ((int)(((byte)(139)))));
            this.panel_Datos.Controls.Add(this.label_name);
            this.panel_Datos.Controls.Add(this.pictureBox_Index);
            this.panel_Datos.Controls.Add(this.label_rol);
            this.panel_Datos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Datos.Location = new System.Drawing.Point(0, 0);
            this.panel_Datos.Name = "panel_Datos";
            this.panel_Datos.Size = new System.Drawing.Size(174, 95);
            this.panel_Datos.TabIndex = 9;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_name.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_name.Location = new System.Drawing.Point(90, 51);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(63, 20);
            this.label_name.TabIndex = 6;
            this.label_name.Text = "nombre";
            // 
            // pictureBox_Index
            // 
            this.pictureBox_Index.Location = new System.Drawing.Point(12, 14);
            this.pictureBox_Index.Name = "pictureBox_Index";
            this.pictureBox_Index.Size = new System.Drawing.Size(69, 60);
            this.pictureBox_Index.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Index.TabIndex = 3;
            this.pictureBox_Index.TabStop = false;
            // 
            // label_rol
            // 
            this.label_rol.AutoSize = true;
            this.label_rol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_rol.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_rol.Location = new System.Drawing.Point(94, 21);
            this.label_rol.Name = "label_rol";
            this.label_rol.Size = new System.Drawing.Size(24, 17);
            this.label_rol.TabIndex = 5;
            this.label_rol.Text = "rol";
            // 
            // button_Opciones
            // 
            this.button_Opciones.FlatAppearance.BorderSize = 0;
            this.button_Opciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Opciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button_Opciones.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button_Opciones.Image = ((System.Drawing.Image)(resources.GetObject("button_Opciones.Image")));
            this.button_Opciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Opciones.Location = new System.Drawing.Point(-3, 295);
            this.button_Opciones.Name = "button_Opciones";
            this.button_Opciones.Size = new System.Drawing.Size(180, 37);
            this.button_Opciones.TabIndex = 8;
            this.button_Opciones.Text = "      Opciones";
            this.button_Opciones.UseVisualStyleBackColor = true;
            this.button_Opciones.Click += new System.EventHandler(this.button_Opciones_Click);
            // 
            // button_LogOut
            // 
            this.button_LogOut.FlatAppearance.BorderSize = 0;
            this.button_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button_LogOut.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button_LogOut.Image = ((System.Drawing.Image)(resources.GetObject("button_LogOut.Image")));
            this.button_LogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_LogOut.Location = new System.Drawing.Point(-3, 487);
            this.button_LogOut.Name = "button_LogOut";
            this.button_LogOut.Size = new System.Drawing.Size(180, 37);
            this.button_LogOut.TabIndex = 7;
            this.button_LogOut.Text = "      Log Out";
            this.button_LogOut.UseVisualStyleBackColor = true;
            this.button_LogOut.Click += new System.EventHandler(this.button_LogOut_Click);
            // 
            // button_Usuarios
            // 
            this.button_Usuarios.FlatAppearance.BorderSize = 0;
            this.button_Usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Usuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button_Usuarios.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button_Usuarios.Image = ((System.Drawing.Image)(resources.GetObject("button_Usuarios.Image")));
            this.button_Usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Usuarios.Location = new System.Drawing.Point(0, 221);
            this.button_Usuarios.Name = "button_Usuarios";
            this.button_Usuarios.Size = new System.Drawing.Size(180, 37);
            this.button_Usuarios.TabIndex = 1;
            this.button_Usuarios.Text = "      Usuarios";
            this.button_Usuarios.UseVisualStyleBackColor = true;
            this.button_Usuarios.Click += new System.EventHandler(this.button_Usuarios_Click);
            // 
            // button_Productos
            // 
            this.button_Productos.FlatAppearance.BorderSize = 0;
            this.button_Productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button_Productos.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button_Productos.Image = ((System.Drawing.Image)(resources.GetObject("button_Productos.Image")));
            this.button_Productos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Productos.Location = new System.Drawing.Point(0, 141);
            this.button_Productos.Name = "button_Productos";
            this.button_Productos.Size = new System.Drawing.Size(177, 37);
            this.button_Productos.TabIndex = 0;
            this.button_Productos.Text = "      Productos";
            this.button_Productos.UseVisualStyleBackColor = true;
            this.button_Productos.Click += new System.EventHandler(this.button_Productos_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(123)))), ((int)(((byte)(208)))));
            this.panelContenedor.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelContenedor.Location = new System.Drawing.Point(166, 27);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1014, 535);
            this.panelContenedor.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(44)))), ((int)(((byte)(127)))));
            this.panel2.Controls.Add(this.btn_minimizar);
            this.panel2.Controls.Add(this.btn_cerrar);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1180, 30);
            this.panel2.TabIndex = 12;
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(1129, 5);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(20, 20);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimizar.TabIndex = 9;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click_1);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(1155, 5);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(20, 20);
            this.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_cerrar.TabIndex = 8;
            this.btn_cerrar.TabStop = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click_1);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1180, 560);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Index";
            this.Text = "Index";
            this.panel1.ResumeLayout(false);
            this.panel_Datos.ResumeLayout(false);
            this.panel_Datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Index)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Productos;
        private System.Windows.Forms.Button button_Usuarios;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pictureBox_Index;
        private System.Windows.Forms.Label label_rol;
        private System.Windows.Forms.Button button_LogOut;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btn_minimizar;
        private System.Windows.Forms.PictureBox btn_cerrar;
        private System.Windows.Forms.Button button_Opciones;
        private System.Windows.Forms.Panel panel_Datos;
    }
}