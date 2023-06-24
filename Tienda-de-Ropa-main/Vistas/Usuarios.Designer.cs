namespace Tienda_de_Ropa.Vistas
{
    partial class Usuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.tablaUsuarios = new System.Windows.Forms.DataGridView();
            this.Foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.txt_agregar_usuario = new System.Windows.Forms.Button();
            this.txt_eliminar_usuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(257, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Usuarios";
            // 
            // tablaUsuarios
            // 
            this.tablaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Foto,
            this.Id,
            this.Nombre,
            this.Rol,
            this.Imagen});
            this.tablaUsuarios.Location = new System.Drawing.Point(45, 132);
            this.tablaUsuarios.Name = "tablaUsuarios";
            this.tablaUsuarios.Size = new System.Drawing.Size(528, 353);
            this.tablaUsuarios.TabIndex = 1;
            // 
            // Foto
            // 
            this.Foto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Foto.HeaderText = "Id";
            this.Foto.Name = "Foto";
            this.Foto.Width = 41;
            // 
            // Id
            // 
            this.Id.HeaderText = "Usuario";
            this.Id.Name = "Id";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            // 
            // Imagen
            // 
            this.Imagen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Imagen.FillWeight = 200F;
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Imagen.Name = "Imagen";
            this.Imagen.Width = 48;
            // 
            // txt_agregar_usuario
            // 
            this.txt_agregar_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(65)))), ((int)(((byte)(147)))));
            this.txt_agregar_usuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_agregar_usuario.FlatAppearance.BorderSize = 0;
            this.txt_agregar_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_agregar_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.txt_agregar_usuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_agregar_usuario.Location = new System.Drawing.Point(766, 132);
            this.txt_agregar_usuario.Name = "txt_agregar_usuario";
            this.txt_agregar_usuario.Size = new System.Drawing.Size(138, 53);
            this.txt_agregar_usuario.TabIndex = 2;
            this.txt_agregar_usuario.Text = "Agregar Usuario";
            this.txt_agregar_usuario.UseVisualStyleBackColor = false;
            this.txt_agregar_usuario.Click += new System.EventHandler(this.txt_agregar_usuario_Click);
            // 
            // txt_eliminar_usuario
            // 
            this.txt_eliminar_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(65)))), ((int)(((byte)(147)))));
            this.txt_eliminar_usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_eliminar_usuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_eliminar_usuario.FlatAppearance.BorderSize = 0;
            this.txt_eliminar_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_eliminar_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.txt_eliminar_usuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_eliminar_usuario.Location = new System.Drawing.Point(766, 237);
            this.txt_eliminar_usuario.Name = "txt_eliminar_usuario";
            this.txt_eliminar_usuario.Size = new System.Drawing.Size(138, 53);
            this.txt_eliminar_usuario.TabIndex = 4;
            this.txt_eliminar_usuario.Text = "Eliminar Usuario";
            this.txt_eliminar_usuario.UseVisualStyleBackColor = false;
            this.txt_eliminar_usuario.Click += new System.EventHandler(this.txt_eliminar_usuario_Click);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(123)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(966, 567);
            this.Controls.Add(this.txt_eliminar_usuario);
            this.Controls.Add(this.txt_agregar_usuario);
            this.Controls.Add(this.tablaUsuarios);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.tablaUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tablaUsuarios;
        private System.Windows.Forms.Button txt_agregar_usuario;
        private System.Windows.Forms.Button txt_eliminar_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewImageColumn Imagen;
    }
}