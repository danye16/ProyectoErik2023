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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLista = new System.Windows.Forms.Button();
            this.btnPilas = new System.Windows.Forms.Button();
            this.btnMatriz = new System.Windows.Forms.Button();
            this.btnColas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLista
            // 
            this.btnLista.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnLista.Location = new System.Drawing.Point(29, 178);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(130, 55);
            this.btnLista.TabIndex = 0;
            this.btnLista.Text = "Listas";
            this.btnLista.UseVisualStyleBackColor = false;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // btnPilas
            // 
            this.btnPilas.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnPilas.Location = new System.Drawing.Point(693, 178);
            this.btnPilas.Name = "btnPilas";
            this.btnPilas.Size = new System.Drawing.Size(130, 55);
            this.btnPilas.TabIndex = 2;
            this.btnPilas.Text = "Pilas";
            this.btnPilas.UseVisualStyleBackColor = false;
            this.btnPilas.Click += new System.EventHandler(this.btnPilas_Click);
            // 
            // btnMatriz
            // 
            this.btnMatriz.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnMatriz.Location = new System.Drawing.Point(353, 12);
            this.btnMatriz.Name = "btnMatriz";
            this.btnMatriz.Size = new System.Drawing.Size(130, 55);
            this.btnMatriz.TabIndex = 3;
            this.btnMatriz.Text = "Matriz";
            this.btnMatriz.UseVisualStyleBackColor = false;
            this.btnMatriz.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnColas
            // 
            this.btnColas.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnColas.Location = new System.Drawing.Point(353, 383);
            this.btnColas.Name = "btnColas";
            this.btnColas.Size = new System.Drawing.Size(130, 55);
            this.btnColas.TabIndex = 4;
            this.btnColas.Text = "Colas";
            this.btnColas.UseVisualStyleBackColor = false;
            this.btnColas.Click += new System.EventHandler(this.btnColas_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(165, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 284);
            this.label1.TabIndex = 5;
            this.label1.Text = "Eleija una Opcion";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnColas);
            this.Controls.Add(this.btnMatriz);
            this.Controls.Add(this.btnPilas);
            this.Controls.Add(this.btnLista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Button btnPilas;
        private System.Windows.Forms.Button btnMatriz;
        private System.Windows.Forms.Button btnColas;
        private System.Windows.Forms.Label label1;
    }
}

