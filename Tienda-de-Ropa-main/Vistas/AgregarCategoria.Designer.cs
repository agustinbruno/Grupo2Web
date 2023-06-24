namespace Tienda_de_Ropa.Vistas
{
    partial class AgregarCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarCategoria));
            this.button_AgregarCat = new System.Windows.Forms.Button();
            this.txt_NombreCat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox_PadreCat = new System.Windows.Forms.ComboBox();
            this.lbl_PadreCat = new System.Windows.Forms.Label();
            this.button_Switch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_AgregarCat
            // 
            this.button_AgregarCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(65)))), ((int)(((byte)(147)))));
            this.button_AgregarCat.FlatAppearance.BorderSize = 0;
            this.button_AgregarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AgregarCat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_AgregarCat.Location = new System.Drawing.Point(167, 180);
            this.button_AgregarCat.Margin = new System.Windows.Forms.Padding(2);
            this.button_AgregarCat.Name = "button_AgregarCat";
            this.button_AgregarCat.Size = new System.Drawing.Size(202, 51);
            this.button_AgregarCat.TabIndex = 13;
            this.button_AgregarCat.Text = "Agregar";
            this.button_AgregarCat.UseVisualStyleBackColor = false;
            this.button_AgregarCat.Click += new System.EventHandler(this.button_AgregarCat_Click);
            // 
            // txt_NombreCat
            // 
            this.txt_NombreCat.Location = new System.Drawing.Point(207, 80);
            this.txt_NombreCat.Margin = new System.Windows.Forms.Padding(2);
            this.txt_NombreCat.Name = "txt_NombreCat";
            this.txt_NombreCat.Size = new System.Drawing.Size(202, 20);
            this.txt_NombreCat.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(112, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(487, 4);
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
            this.panel2.Size = new System.Drawing.Size(517, 30);
            this.panel2.TabIndex = 23;
            // 
            // comboBox_PadreCat
            // 
            this.comboBox_PadreCat.FormattingEnabled = true;
            this.comboBox_PadreCat.Location = new System.Drawing.Point(207, 132);
            this.comboBox_PadreCat.Name = "comboBox_PadreCat";
            this.comboBox_PadreCat.Size = new System.Drawing.Size(202, 21);
            this.comboBox_PadreCat.TabIndex = 24;
            // 
            // lbl_PadreCat
            // 
            this.lbl_PadreCat.AutoSize = true;
            this.lbl_PadreCat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_PadreCat.Location = new System.Drawing.Point(97, 135);
            this.lbl_PadreCat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_PadreCat.Name = "lbl_PadreCat";
            this.lbl_PadreCat.Size = new System.Drawing.Size(83, 13);
            this.lbl_PadreCat.TabIndex = 25;
            this.lbl_PadreCat.Text = "Padre Categoria";
            // 
            // button_Switch
            // 
            this.button_Switch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(65)))), ((int)(((byte)(147)))));
            this.button_Switch.FlatAppearance.BorderSize = 0;
            this.button_Switch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Switch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Switch.Location = new System.Drawing.Point(428, 44);
            this.button_Switch.Margin = new System.Windows.Forms.Padding(2);
            this.button_Switch.Name = "button_Switch";
            this.button_Switch.Size = new System.Drawing.Size(78, 26);
            this.button_Switch.TabIndex = 26;
            this.button_Switch.Text = "Categoria";
            this.button_Switch.UseVisualStyleBackColor = false;
            this.button_Switch.Click += new System.EventHandler(this.button_Switch_Click);
            // 
            // AgregarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(123)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(517, 253);
            this.Controls.Add(this.button_Switch);
            this.Controls.Add(this.lbl_PadreCat);
            this.Controls.Add(this.comboBox_PadreCat);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button_AgregarCat);
            this.Controls.Add(this.txt_NombreCat);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarCategoria";
            this.Text = "AgregarCategoria";
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_AgregarCat;
        private System.Windows.Forms.TextBox txt_NombreCat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btn_cerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox_PadreCat;
        private System.Windows.Forms.Label lbl_PadreCat;
        private System.Windows.Forms.Button button_Switch;
    }
}