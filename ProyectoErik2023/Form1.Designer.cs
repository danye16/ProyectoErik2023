namespace ProyectoErik2023
{
    partial class Form1
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
            this.btnLista = new System.Windows.Forms.Button();
            this.btnPilas = new System.Windows.Forms.Button();
            this.btnMatriz = new System.Windows.Forms.Button();
            this.btnColas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLista
            // 
            this.btnLista.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLista.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLista.Location = new System.Drawing.Point(39, 219);
            this.btnLista.Margin = new System.Windows.Forms.Padding(4);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(173, 68);
            this.btnLista.TabIndex = 0;
            this.btnLista.Text = "Listas";
            this.btnLista.UseVisualStyleBackColor = false;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // btnPilas
            // 
            this.btnPilas.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPilas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPilas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chartreuse;
            this.btnPilas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chartreuse;
            this.btnPilas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPilas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPilas.Location = new System.Drawing.Point(924, 219);
            this.btnPilas.Margin = new System.Windows.Forms.Padding(4);
            this.btnPilas.Name = "btnPilas";
            this.btnPilas.Size = new System.Drawing.Size(173, 68);
            this.btnPilas.TabIndex = 2;
            this.btnPilas.Text = "Pilas";
            this.btnPilas.UseVisualStyleBackColor = false;
            this.btnPilas.Click += new System.EventHandler(this.btnPilas_Click);
            // 
            // btnMatriz
            // 
            this.btnMatriz.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMatriz.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMatriz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMatriz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMatriz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatriz.Location = new System.Drawing.Point(471, 15);
            this.btnMatriz.Margin = new System.Windows.Forms.Padding(4);
            this.btnMatriz.Name = "btnMatriz";
            this.btnMatriz.Size = new System.Drawing.Size(173, 68);
            this.btnMatriz.TabIndex = 3;
            this.btnMatriz.Text = "Matriz";
            this.btnMatriz.UseVisualStyleBackColor = false;
            this.btnMatriz.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnColas
            // 
            this.btnColas.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnColas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnColas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnColas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnColas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColas.Location = new System.Drawing.Point(471, 491);
            this.btnColas.Margin = new System.Windows.Forms.Padding(4);
            this.btnColas.Name = "btnColas";
            this.btnColas.Size = new System.Drawing.Size(173, 68);
            this.btnColas.TabIndex = 4;
            this.btnColas.Text = "Colas";
            this.btnColas.UseVisualStyleBackColor = false;
            this.btnColas.Click += new System.EventHandler(this.btnColas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox1.Image = global::ProyectoErik2023.Properties.Resources.menuprincipal;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1125, 665);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 554);
            this.Controls.Add(this.btnColas);
            this.Controls.Add(this.btnMatriz);
            this.Controls.Add(this.btnPilas);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Button btnPilas;
        private System.Windows.Forms.Button btnMatriz;
        private System.Windows.Forms.Button btnColas;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

