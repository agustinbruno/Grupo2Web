namespace Tienda_de_Ropa.Vistas
{
    partial class Productos
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btn_cats = new System.Windows.Forms.Button();
            this.btn_prods = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(20, 74);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1037, 493);
            this.panelContainer.TabIndex = 5;
            // 
            // btn_cats
            // 
            this.btn_cats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(65)))), ((int)(((byte)(147)))));
            this.btn_cats.FlatAppearance.BorderSize = 0;
            this.btn_cats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cats.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_cats.Location = new System.Drawing.Point(192, 22);
            this.btn_cats.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cats.Name = "btn_cats";
            this.btn_cats.Size = new System.Drawing.Size(131, 38);
            this.btn_cats.TabIndex = 4;
            this.btn_cats.Text = "Categorias";
            this.btn_cats.UseVisualStyleBackColor = false;
            this.btn_cats.Click += new System.EventHandler(this.btn_cats_Click);
            // 
            // btn_prods
            // 
            this.btn_prods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(65)))), ((int)(((byte)(147)))));
            this.btn_prods.FlatAppearance.BorderSize = 0;
            this.btn_prods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prods.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_prods.Location = new System.Drawing.Point(44, 21);
            this.btn_prods.Margin = new System.Windows.Forms.Padding(2);
            this.btn_prods.Name = "btn_prods";
            this.btn_prods.Size = new System.Drawing.Size(124, 40);
            this.btn_prods.TabIndex = 3;
            this.btn_prods.Text = "Productoss";
            this.btn_prods.UseVisualStyleBackColor = false;
            this.btn_prods.Click += new System.EventHandler(this.btn_prods_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(123)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(1091, 586);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.btn_cats);
            this.Controls.Add(this.btn_prods);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productos";
            this.Text = "Productos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btn_cats;
        private System.Windows.Forms.Button btn_prods;
    }
}