
namespace PorraGironaOfficial
{
    partial class FormCrearApuesta
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
            this.lblApuesta = new System.Windows.Forms.Label();
            this.lblidParitdo = new System.Windows.Forms.Label();
            this.lblGolLocal = new System.Windows.Forms.Label();
            this.lblGolVisitant = new System.Windows.Forms.Label();
            this.txtIDpartit = new System.Windows.Forms.TextBox();
            this.txtGolLocal = new System.Windows.Forms.TextBox();
            this.txtGolVisitant = new System.Windows.Forms.TextBox();
            this.btnApostar = new System.Windows.Forms.Button();
            this.lblMsgError = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVerPartidos = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.lblAlias = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblApuesta
            // 
            this.lblApuesta.AutoSize = true;
            this.lblApuesta.Font = new System.Drawing.Font("Berlin Sans FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApuesta.ForeColor = System.Drawing.Color.White;
            this.lblApuesta.Location = new System.Drawing.Point(13, 11);
            this.lblApuesta.Name = "lblApuesta";
            this.lblApuesta.Size = new System.Drawing.Size(222, 54);
            this.lblApuesta.TabIndex = 0;
            this.lblApuesta.Text = "APUESTA";
            // 
            // lblidParitdo
            // 
            this.lblidParitdo.AutoSize = true;
            this.lblidParitdo.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblidParitdo.ForeColor = System.Drawing.Color.White;
            this.lblidParitdo.Location = new System.Drawing.Point(58, 318);
            this.lblidParitdo.Name = "lblidParitdo";
            this.lblidParitdo.Size = new System.Drawing.Size(134, 26);
            this.lblidParitdo.TabIndex = 1;
            this.lblidParitdo.Text = "ID PARTIDO";
            // 
            // lblGolLocal
            // 
            this.lblGolLocal.AutoSize = true;
            this.lblGolLocal.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGolLocal.ForeColor = System.Drawing.Color.White;
            this.lblGolLocal.Location = new System.Drawing.Point(58, 418);
            this.lblGolLocal.Name = "lblGolLocal";
            this.lblGolLocal.Size = new System.Drawing.Size(247, 26);
            this.lblGolLocal.TabIndex = 2;
            this.lblGolLocal.Text = "GOLES EQUIPO LOCAL";
            // 
            // lblGolVisitant
            // 
            this.lblGolVisitant.AutoSize = true;
            this.lblGolVisitant.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGolVisitant.ForeColor = System.Drawing.Color.White;
            this.lblGolVisitant.Location = new System.Drawing.Point(58, 522);
            this.lblGolVisitant.Name = "lblGolVisitant";
            this.lblGolVisitant.Size = new System.Drawing.Size(282, 26);
            this.lblGolVisitant.TabIndex = 3;
            this.lblGolVisitant.Text = "GOLES EQUIPO VISITANTE";
            // 
            // txtIDpartit
            // 
            this.txtIDpartit.Location = new System.Drawing.Point(64, 360);
            this.txtIDpartit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIDpartit.Name = "txtIDpartit";
            this.txtIDpartit.Size = new System.Drawing.Size(385, 31);
            this.txtIDpartit.TabIndex = 4;
            // 
            // txtGolLocal
            // 
            this.txtGolLocal.Location = new System.Drawing.Point(64, 458);
            this.txtGolLocal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGolLocal.Name = "txtGolLocal";
            this.txtGolLocal.Size = new System.Drawing.Size(385, 31);
            this.txtGolLocal.TabIndex = 5;
            // 
            // txtGolVisitant
            // 
            this.txtGolVisitant.Location = new System.Drawing.Point(64, 562);
            this.txtGolVisitant.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGolVisitant.Name = "txtGolVisitant";
            this.txtGolVisitant.Size = new System.Drawing.Size(385, 31);
            this.txtGolVisitant.TabIndex = 6;
            // 
            // btnApostar
            // 
            this.btnApostar.BackColor = System.Drawing.Color.Transparent;
            this.btnApostar.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnApostar.FlatAppearance.BorderSize = 4;
            this.btnApostar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnApostar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnApostar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApostar.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnApostar.ForeColor = System.Drawing.Color.IndianRed;
            this.btnApostar.Location = new System.Drawing.Point(64, 648);
            this.btnApostar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnApostar.Name = "btnApostar";
            this.btnApostar.Size = new System.Drawing.Size(385, 72);
            this.btnApostar.TabIndex = 7;
            this.btnApostar.Text = "APOSTAR";
            this.btnApostar.UseVisualStyleBackColor = false;
            this.btnApostar.Click += new System.EventHandler(this.btnApostar_Click);
            // 
            // lblMsgError
            // 
            this.lblMsgError.AutoSize = true;
            this.lblMsgError.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMsgError.ForeColor = System.Drawing.Color.White;
            this.lblMsgError.Location = new System.Drawing.Point(73, 724);
            this.lblMsgError.Name = "lblMsgError";
            this.lblMsgError.Size = new System.Drawing.Size(76, 20);
            this.lblMsgError.TabIndex = 8;
            this.lblMsgError.Text = "msgError";
            this.lblMsgError.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(1453, 11);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 79);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBack.FlatAppearance.BorderSize = 2;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(1370, 11);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(77, 79);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "<-";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1473, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Exit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1380, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Back";
            // 
            // btnVerPartidos
            // 
            this.btnVerPartidos.BackColor = System.Drawing.Color.Transparent;
            this.btnVerPartidos.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnVerPartidos.FlatAppearance.BorderSize = 4;
            this.btnVerPartidos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnVerPartidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnVerPartidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerPartidos.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVerPartidos.ForeColor = System.Drawing.Color.IndianRed;
            this.btnVerPartidos.Location = new System.Drawing.Point(64, 140);
            this.btnVerPartidos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVerPartidos.Name = "btnVerPartidos";
            this.btnVerPartidos.Size = new System.Drawing.Size(385, 72);
            this.btnVerPartidos.TabIndex = 13;
            this.btnVerPartidos.Text = "VER PARTIDOS DISPONIBLES";
            this.btnVerPartidos.UseVisualStyleBackColor = false;
            this.btnVerPartidos.Click += new System.EventHandler(this.btnVerPartidos_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(495, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1018, 516);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.Visible = false;
            // 
            // txtAlias
            // 
            this.txtAlias.Location = new System.Drawing.Point(64, 270);
            this.txtAlias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(385, 31);
            this.txtAlias.TabIndex = 16;
            // 
            // lblAlias
            // 
            this.lblAlias.AutoSize = true;
            this.lblAlias.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAlias.ForeColor = System.Drawing.Color.White;
            this.lblAlias.Location = new System.Drawing.Point(58, 228);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.Size = new System.Drawing.Size(72, 26);
            this.lblAlias.TabIndex = 15;
            this.lblAlias.Text = "ALIAS";
            // 
            // FormCrearApuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1539, 790);
            this.Controls.Add(this.txtAlias);
            this.Controls.Add(this.lblAlias);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnVerPartidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblMsgError);
            this.Controls.Add(this.btnApostar);
            this.Controls.Add(this.txtGolVisitant);
            this.Controls.Add(this.txtGolLocal);
            this.Controls.Add(this.txtIDpartit);
            this.Controls.Add(this.lblGolVisitant);
            this.Controls.Add(this.lblGolLocal);
            this.Controls.Add(this.lblidParitdo);
            this.Controls.Add(this.lblApuesta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCrearApuesta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApuesta;
        private System.Windows.Forms.Label lblidParitdo;
        private System.Windows.Forms.Label lblGolLocal;
        private System.Windows.Forms.Label lblGolVisitant;
        private System.Windows.Forms.TextBox txtIDpartit;
        private System.Windows.Forms.TextBox txtGolLocal;
        private System.Windows.Forms.TextBox txtGolVisitant;
        private System.Windows.Forms.Button btnApostar;
        private System.Windows.Forms.Label lblMsgError;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVerPartidos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtAlias;
        private System.Windows.Forms.Label lblAlias;
    }
}

