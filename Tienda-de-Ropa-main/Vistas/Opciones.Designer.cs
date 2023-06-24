namespace Tienda_de_Ropa.Vistas
{
    partial class Opciones
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
            this.pictureBox_Opciones = new System.Windows.Forms.PictureBox();
            this.button_CambiarFoto = new System.Windows.Forms.Button();
            this.label_Rol = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.lbl_errorOpciones = new System.Windows.Forms.Label();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Opciones)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Opciones
            // 
            this.pictureBox_Opciones.Location = new System.Drawing.Point(133, 114);
            this.pictureBox_Opciones.Name = "pictureBox_Opciones";
            this.pictureBox_Opciones.Size = new System.Drawing.Size(199, 191);
            this.pictureBox_Opciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Opciones.TabIndex = 0;
            this.pictureBox_Opciones.TabStop = false;
            // 
            // button_CambiarFoto
            // 
            this.button_CambiarFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(65)))), ((int)(((byte)(147)))));
            this.button_CambiarFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_CambiarFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_CambiarFoto.FlatAppearance.BorderSize = 0;
            this.button_CambiarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CambiarFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.button_CambiarFoto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_CambiarFoto.Location = new System.Drawing.Point(133, 336);
            this.button_CambiarFoto.Name = "button_CambiarFoto";
            this.button_CambiarFoto.Size = new System.Drawing.Size(199, 49);
            this.button_CambiarFoto.TabIndex = 1;
            this.button_CambiarFoto.Text = "Cambiar Foto";
            this.button_CambiarFoto.UseVisualStyleBackColor = false;
            this.button_CambiarFoto.Click += new System.EventHandler(this.button_CambiarFoto_Click);
            // 
            // label_Rol
            // 
            this.label_Rol.AutoSize = true;
            this.label_Rol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_Rol.Location = new System.Drawing.Point(682, 137);
            this.label_Rol.Name = "label_Rol";
            this.label_Rol.Size = new System.Drawing.Size(25, 18);
            this.label_Rol.TabIndex = 2;
            this.label_Rol.Text = "rol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(422, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "Opciones de Cuenta";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Nombre.Location = new System.Drawing.Point(482, 132);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(175, 26);
            this.txt_Nombre.TabIndex = 6;
            this.txt_Nombre.Text = "Nombre";
            this.txt_Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Contraseña.Location = new System.Drawing.Point(482, 226);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.Size = new System.Drawing.Size(175, 26);
            this.txt_Contraseña.TabIndex = 9;
            this.txt_Contraseña.Text = "Contraseña";
            this.txt_Contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_Guardar
            // 
            this.button_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(65)))), ((int)(((byte)(147)))));
            this.button_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Guardar.FlatAppearance.BorderSize = 0;
            this.button_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.button_Guardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Guardar.Location = new System.Drawing.Point(482, 306);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(175, 37);
            this.button_Guardar.TabIndex = 10;
            this.button_Guardar.Text = "Guardar Cambios";
            this.button_Guardar.UseVisualStyleBackColor = false;
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click_1);
            // 
            // lbl_errorOpciones
            // 
            this.lbl_errorOpciones.AutoSize = true;
            this.lbl_errorOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_errorOpciones.ForeColor = System.Drawing.Color.Red;
            this.lbl_errorOpciones.Location = new System.Drawing.Point(545, 275);
            this.lbl_errorOpciones.Name = "lbl_errorOpciones";
            this.lbl_errorOpciones.Size = new System.Drawing.Size(56, 18);
            this.lbl_errorOpciones.TabIndex = 21;
            this.lbl_errorOpciones.Text = "errores";
            // 
            // txt_Correo
            // 
            this.txt_Correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Correo.Location = new System.Drawing.Point(482, 180);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(175, 26);
            this.txt_Correo.TabIndex = 22;
            this.txt_Correo.Text = "Correo";
            this.txt_Correo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Opciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(123)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(863, 468);
            this.Controls.Add(this.txt_Correo);
            this.Controls.Add(this.lbl_errorOpciones);
            this.Controls.Add(this.button_Guardar);
            this.Controls.Add(this.txt_Contraseña);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_Rol);
            this.Controls.Add(this.button_CambiarFoto);
            this.Controls.Add(this.pictureBox_Opciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Opciones";
            this.Text = "Opciones";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Opciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Opciones;
        private System.Windows.Forms.Button button_CambiarFoto;
        private System.Windows.Forms.Label label_Rol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Contraseña;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.Label lbl_errorOpciones;
        private System.Windows.Forms.TextBox txt_Correo;
    }
}