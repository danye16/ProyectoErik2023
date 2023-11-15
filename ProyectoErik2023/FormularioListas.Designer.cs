namespace ProyectoErik2023
{
    partial class FormularioListas
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
            this.agregar_elemento = new System.Windows.Forms.Button();
            this.btn_ascendente_lista = new System.Windows.Forms.Button();
            this.btn_imprimir_lista = new System.Windows.Forms.Button();
            this.limpia_lista = new System.Windows.Forms.Button();
            this.btn_buscar_lista = new System.Windows.Forms.Button();
            this.btn_descendente_lista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // agregar_elemento
            // 
            this.agregar_elemento.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.agregar_elemento.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar_elemento.Location = new System.Drawing.Point(30, 30);
            this.agregar_elemento.Name = "agregar_elemento";
            this.agregar_elemento.Size = new System.Drawing.Size(163, 69);
            this.agregar_elemento.TabIndex = 0;
            this.agregar_elemento.Text = "Agregar Elemento";
            this.agregar_elemento.UseVisualStyleBackColor = false;
            // 
            // btn_ascendente_lista
            // 
            this.btn_ascendente_lista.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ascendente_lista.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ascendente_lista.Location = new System.Drawing.Point(318, 236);
            this.btn_ascendente_lista.Name = "btn_ascendente_lista";
            this.btn_ascendente_lista.Size = new System.Drawing.Size(163, 69);
            this.btn_ascendente_lista.TabIndex = 1;
            this.btn_ascendente_lista.Text = "Ordenar Ascendente";
            this.btn_ascendente_lista.UseVisualStyleBackColor = false;
            // 
            // btn_imprimir_lista
            // 
            this.btn_imprimir_lista.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_imprimir_lista.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir_lista.Location = new System.Drawing.Point(605, 30);
            this.btn_imprimir_lista.Name = "btn_imprimir_lista";
            this.btn_imprimir_lista.Size = new System.Drawing.Size(163, 69);
            this.btn_imprimir_lista.TabIndex = 2;
            this.btn_imprimir_lista.Text = "Imprimir Lista";
            this.btn_imprimir_lista.UseVisualStyleBackColor = false;
            // 
            // limpia_lista
            // 
            this.limpia_lista.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.limpia_lista.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpia_lista.Location = new System.Drawing.Point(318, 90);
            this.limpia_lista.Name = "limpia_lista";
            this.limpia_lista.Size = new System.Drawing.Size(163, 69);
            this.limpia_lista.TabIndex = 3;
            this.limpia_lista.Text = "Limpiar Lista";
            this.limpia_lista.UseVisualStyleBackColor = false;
            // 
            // btn_buscar_lista
            // 
            this.btn_buscar_lista.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_buscar_lista.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar_lista.Location = new System.Drawing.Point(30, 303);
            this.btn_buscar_lista.Name = "btn_buscar_lista";
            this.btn_buscar_lista.Size = new System.Drawing.Size(163, 69);
            this.btn_buscar_lista.TabIndex = 4;
            this.btn_buscar_lista.Text = "Buscar Elemento";
            this.btn_buscar_lista.UseVisualStyleBackColor = false;
            // 
            // btn_descendente_lista
            // 
            this.btn_descendente_lista.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_descendente_lista.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_descendente_lista.Location = new System.Drawing.Point(605, 289);
            this.btn_descendente_lista.Name = "btn_descendente_lista";
            this.btn_descendente_lista.Size = new System.Drawing.Size(163, 69);
            this.btn_descendente_lista.TabIndex = 5;
            this.btn_descendente_lista.Text = "Ordenar Descendente";
            this.btn_descendente_lista.UseVisualStyleBackColor = false;
            // 
            // FormularioListas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_descendente_lista);
            this.Controls.Add(this.btn_buscar_lista);
            this.Controls.Add(this.limpia_lista);
            this.Controls.Add(this.btn_imprimir_lista);
            this.Controls.Add(this.btn_ascendente_lista);
            this.Controls.Add(this.agregar_elemento);
            this.Name = "FormularioListas";
            this.Text = "FormularioListas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button agregar_elemento;
        private System.Windows.Forms.Button btn_ascendente_lista;
        private System.Windows.Forms.Button btn_imprimir_lista;
        private System.Windows.Forms.Button limpia_lista;
        private System.Windows.Forms.Button btn_buscar_lista;
        private System.Windows.Forms.Button btn_descendente_lista;
    }
}