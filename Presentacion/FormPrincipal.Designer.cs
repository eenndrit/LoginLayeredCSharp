
namespace PorraGironaOfficial
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1Login = new System.Windows.Forms.Label();
            this.label1user = new System.Windows.Forms.Label();
            this.label3contraseña = new System.Windows.Forms.Label();
            this.label2login = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.linkRecuperarContra = new System.Windows.Forms.LinkLabel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.labelErrorMessage = new System.Windows.Forms.Label();
            this.labelErrorMessage2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.escudo_girona;
            this.pictureBox1.Location = new System.Drawing.Point(13, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1Login
            // 
            this.label1Login.AutoSize = true;
            this.label1Login.BackColor = System.Drawing.Color.Transparent;
            this.label1Login.Font = new System.Drawing.Font("Rockwell Nova Cond", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1Login.ForeColor = System.Drawing.SystemColors.Window;
            this.label1Login.Location = new System.Drawing.Point(2037, 562);
            this.label1Login.Name = "label1Login";
            this.label1Login.Size = new System.Drawing.Size(120, 64);
            this.label1Login.TabIndex = 1;
            this.label1Login.Text = "LOGIN";
            // 
            // label1user
            // 
            this.label1user.AutoSize = true;
            this.label1user.BackColor = System.Drawing.Color.Transparent;
            this.label1user.Font = new System.Drawing.Font("Berlin Sans FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1user.ForeColor = System.Drawing.Color.IndianRed;
            this.label1user.Location = new System.Drawing.Point(814, 326);
            this.label1user.Name = "label1user";
            this.label1user.Size = new System.Drawing.Size(143, 35);
            this.label1user.TabIndex = 2;
            this.label1user.Text = "USUARIO";
            // 
            // label3contraseña
            // 
            this.label3contraseña.AutoSize = true;
            this.label3contraseña.BackColor = System.Drawing.Color.Transparent;
            this.label3contraseña.Font = new System.Drawing.Font("Berlin Sans FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3contraseña.ForeColor = System.Drawing.Color.IndianRed;
            this.label3contraseña.Location = new System.Drawing.Point(818, 415);
            this.label3contraseña.Name = "label3contraseña";
            this.label3contraseña.Size = new System.Drawing.Size(212, 35);
            this.label3contraseña.TabIndex = 4;
            this.label3contraseña.Text = "CONTRASEÑA";
            // 
            // label2login
            // 
            this.label2login.AutoSize = true;
            this.label2login.BackColor = System.Drawing.Color.Transparent;
            this.label2login.Font = new System.Drawing.Font("Berlin Sans FB", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2login.ForeColor = System.Drawing.Color.IndianRed;
            this.label2login.Location = new System.Drawing.Point(850, 100);
            this.label2login.Name = "label2login";
            this.label2login.Size = new System.Drawing.Size(322, 105);
            this.label2login.TabIndex = 5;
            this.label2login.Text = "LOGIN";
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.DarkRed;
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Font = new System.Drawing.Font("Berlin Sans FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContraseña.ForeColor = System.Drawing.Color.White;
            this.txtContraseña.Location = new System.Drawing.Point(818, 454);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(367, 36);
            this.txtContraseña.TabIndex = 2;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.DarkRed;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Berlin Sans FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUser.ForeColor = System.Drawing.Color.White;
            this.txtUser.Location = new System.Drawing.Point(818, 365);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(367, 36);
            this.txtUser.TabIndex = 1;
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.Transparent;
            this.btnAcceder.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAcceder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAcceder.FlatAppearance.BorderSize = 3;
            this.btnAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAcceder.ForeColor = System.Drawing.Color.LightCoral;
            this.btnAcceder.Location = new System.Drawing.Point(814, 498);
            this.btnAcceder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(366, 58);
            this.btnAcceder.TabIndex = 3;
            this.btnAcceder.Text = "ACCEDER";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // linkRecuperarContra
            // 
            this.linkRecuperarContra.AutoSize = true;
            this.linkRecuperarContra.BackColor = System.Drawing.Color.Transparent;
            this.linkRecuperarContra.Font = new System.Drawing.Font("Berlin Sans FB", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkRecuperarContra.LinkColor = System.Drawing.Color.IndianRed;
            this.linkRecuperarContra.Location = new System.Drawing.Point(900, 603);
            this.linkRecuperarContra.Name = "linkRecuperarContra";
            this.linkRecuperarContra.Size = new System.Drawing.Size(196, 18);
            this.linkRecuperarContra.TabIndex = 0;
            this.linkRecuperarContra.TabStop = true;
            this.linkRecuperarContra.Text = "¿Has olvidado la contraseña?";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1072, 22);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(49, 29);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 10;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Image = global::Presentacion.Properties.Resources.icone_x_noir;
            this.btnCerrar.Location = new System.Drawing.Point(1132, 9);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(53, 55);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearUsuario.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCrearUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCrearUsuario.FlatAppearance.BorderSize = 3;
            this.btnCrearUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCrearUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearUsuario.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCrearUsuario.ForeColor = System.Drawing.Color.LightCoral;
            this.btnCrearUsuario.Location = new System.Drawing.Point(818, 645);
            this.btnCrearUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(366, 58);
            this.btnCrearUsuario.TabIndex = 12;
            this.btnCrearUsuario.Text = "CREAR USUARIO";
            this.btnCrearUsuario.UseVisualStyleBackColor = false;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // labelErrorMessage
            // 
            this.labelErrorMessage.AutoSize = true;
            this.labelErrorMessage.BackColor = System.Drawing.Color.Transparent;
            this.labelErrorMessage.Font = new System.Drawing.Font("Berlin Sans FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.labelErrorMessage.Location = new System.Drawing.Point(1637, 903);
            this.labelErrorMessage.Name = "labelErrorMessage";
            this.labelErrorMessage.Size = new System.Drawing.Size(0, 24);
            this.labelErrorMessage.TabIndex = 13;
            // 
            // labelErrorMessage2
            // 
            this.labelErrorMessage2.AutoSize = true;
            this.labelErrorMessage2.BackColor = System.Drawing.Color.Transparent;
            this.labelErrorMessage2.Font = new System.Drawing.Font("Berlin Sans FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelErrorMessage2.ForeColor = System.Drawing.Color.White;
            this.labelErrorMessage2.Location = new System.Drawing.Point(814, 560);
            this.labelErrorMessage2.Name = "labelErrorMessage2";
            this.labelErrorMessage2.Size = new System.Drawing.Size(136, 24);
            this.labelErrorMessage2.TabIndex = 14;
            this.labelErrorMessage2.Text = "Error Message";
            this.labelErrorMessage2.Visible = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.HD_wallpaper_cristhian_stuani_goal_girona_fc_joy_la_liga_uruguayan_footballers_cristhian_ricardo_stuani_curbelo_neon_lights_soccer_laliga_spain;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1202, 735);
            this.Controls.Add(this.labelErrorMessage2);
            this.Controls.Add(this.labelErrorMessage);
            this.Controls.Add(this.btnCrearUsuario);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.linkRecuperarContra);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.label2login);
            this.Controls.Add(this.label3contraseña);
            this.Controls.Add(this.label1user);
            this.Controls.Add(this.label1Login);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormPrincipal";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1Login;
        private System.Windows.Forms.Label label1user;
        private System.Windows.Forms.Label label3contraseña;
        private System.Windows.Forms.Label label2login;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.LinkLabel linkRecuperarContra;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.Label labelErrorMessage;
        private System.Windows.Forms.Label labelErrorMessage2;
    }
}

