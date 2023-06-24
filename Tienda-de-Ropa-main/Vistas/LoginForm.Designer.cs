namespace Tienda_de_Ropa.Vistas
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.lbl_titulo_login = new System.Windows.Forms.Label();
            this.lbl_error_login = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.PictureBox();
            this.btn_minimizar = new System.Windows.Forms.PictureBox();
            this.panel_Login = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            this.panel_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(44)))), ((int)(((byte)(127)))));
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.btn_login.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_login.Location = new System.Drawing.Point(59, 247);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(258, 33);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "ACCEDER";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txt_usuario.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txt_usuario.Location = new System.Drawing.Point(59, 110);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(258, 26);
            this.txt_usuario.TabIndex = 1;
            this.txt_usuario.Text = "Usuario";
            this.txt_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_usuario.Enter += new System.EventHandler(this.txt_usuario_Enter);
            this.txt_usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_usuario_KeyPress);
            this.txt_usuario.Leave += new System.EventHandler(this.txt_usuario_Leave);
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.AccessibleName = "";
            this.txt_contraseña.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_contraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txt_contraseña.Location = new System.Drawing.Point(59, 154);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(258, 26);
            this.txt_contraseña.TabIndex = 3;
            this.txt_contraseña.Text = "Contraseña";
            this.txt_contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_contraseña.Enter += new System.EventHandler(this.txt_contraseña_Enter);
            this.txt_contraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_contraseña_KeyPress);
            this.txt_contraseña.Leave += new System.EventHandler(this.txt_contraseña_Leave);
            // 
            // lbl_titulo_login
            // 
            this.lbl_titulo_login.AutoSize = true;
            this.lbl_titulo_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_titulo_login.Location = new System.Drawing.Point(88, 44);
            this.lbl_titulo_login.Name = "lbl_titulo_login";
            this.lbl_titulo_login.Size = new System.Drawing.Size(191, 31);
            this.lbl_titulo_login.TabIndex = 5;
            this.lbl_titulo_login.Text = "Iniciar Sesion";
            // 
            // lbl_error_login
            // 
            this.lbl_error_login.AutoSize = true;
            this.lbl_error_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_login.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_error_login.Location = new System.Drawing.Point(106, 187);
            this.lbl_error_login.Name = "lbl_error_login";
            this.lbl_error_login.Size = new System.Drawing.Size(183, 16);
            this.lbl_error_login.TabIndex = 7;
            this.lbl_error_login.Text = "*Error al Ingresar Usuario";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.ErrorImage")));
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(349, 5);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(20, 20);
            this.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_cerrar.TabIndex = 8;
            this.btn_cerrar.TabStop = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(323, 5);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(20, 20);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimizar.TabIndex = 9;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // panel_Login
            // 
            this.panel_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(44)))), ((int)(((byte)(127)))));
            this.panel_Login.Controls.Add(this.btn_minimizar);
            this.panel_Login.Controls.Add(this.btn_cerrar);
            this.panel_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_Login.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Login.Location = new System.Drawing.Point(0, 0);
            this.panel_Login.Name = "panel_Login";
            this.panel_Login.Size = new System.Drawing.Size(373, 30);
            this.panel_Login.TabIndex = 10;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(123)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(373, 311);
            this.Controls.Add(this.panel_Login);
            this.Controls.Add(this.lbl_error_login);
            this.Controls.Add(this.lbl_titulo_login);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.btn_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            this.panel_Login.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Label lbl_titulo_login;
        private System.Windows.Forms.Label lbl_error_login;
        private System.Windows.Forms.PictureBox btn_cerrar;
        private System.Windows.Forms.PictureBox btn_minimizar;
        private System.Windows.Forms.Panel panel_Login;
    }
}