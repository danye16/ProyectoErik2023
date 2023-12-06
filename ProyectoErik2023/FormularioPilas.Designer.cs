namespace ProyectoErik2023
{
    partial class FormularioPilas
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
            this.btn_descendente_pila = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtEliminarCima = new System.Windows.Forms.Button();
            this.btn_imprimir_pila = new System.Windows.Forms.Button();
            this.btn_ascendente_pila = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMemoriaRam = new System.Windows.Forms.TextBox();
            this.txtTarjetaVideo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSSD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRGB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnLimpiarTodo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_descendente_pila
            // 
            this.btn_descendente_pila.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_descendente_pila.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_descendente_pila.Location = new System.Drawing.Point(606, 313);
            this.btn_descendente_pila.Name = "btn_descendente_pila";
            this.btn_descendente_pila.Size = new System.Drawing.Size(163, 69);
            this.btn_descendente_pila.TabIndex = 17;
            this.btn_descendente_pila.Text = "Ordenar Descendente";
            this.btn_descendente_pila.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(197, 299);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(163, 69);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar Elemento";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtEliminarCima
            // 
            this.txtEliminarCima.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtEliminarCima.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEliminarCima.Location = new System.Drawing.Point(317, 194);
            this.txtEliminarCima.Name = "txtEliminarCima";
            this.txtEliminarCima.Size = new System.Drawing.Size(163, 69);
            this.txtEliminarCima.TabIndex = 15;
            this.txtEliminarCima.Text = "Eliminar cima";
            this.txtEliminarCima.UseVisualStyleBackColor = false;
            this.txtEliminarCima.Click += new System.EventHandler(this.txtEliminarCima_Click);
            // 
            // btn_imprimir_pila
            // 
            this.btn_imprimir_pila.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_imprimir_pila.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir_pila.Location = new System.Drawing.Point(606, 100);
            this.btn_imprimir_pila.Name = "btn_imprimir_pila";
            this.btn_imprimir_pila.Size = new System.Drawing.Size(163, 69);
            this.btn_imprimir_pila.TabIndex = 14;
            this.btn_imprimir_pila.Text = "Imprimir Pila";
            this.btn_imprimir_pila.UseVisualStyleBackColor = false;
            this.btn_imprimir_pila.Click += new System.EventHandler(this.btn_imprimir_pila_Click);
            // 
            // btn_ascendente_pila
            // 
            this.btn_ascendente_pila.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ascendente_pila.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ascendente_pila.Location = new System.Drawing.Point(606, 175);
            this.btn_ascendente_pila.Name = "btn_ascendente_pila";
            this.btn_ascendente_pila.Size = new System.Drawing.Size(163, 69);
            this.btn_ascendente_pila.TabIndex = 13;
            this.btn_ascendente_pila.Text = "Ordenar Ascendente";
            this.btn_ascendente_pila.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregar.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(317, 66);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(163, 69);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar Elemento";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.agregar_elementoP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Memoria Ram";
            // 
            // txtMemoriaRam
            // 
            this.txtMemoriaRam.Location = new System.Drawing.Point(12, 39);
            this.txtMemoriaRam.Name = "txtMemoriaRam";
            this.txtMemoriaRam.Size = new System.Drawing.Size(100, 20);
            this.txtMemoriaRam.TabIndex = 19;
            this.txtMemoriaRam.TextChanged += new System.EventHandler(this.txtMemoriaRam_TextChanged);
            // 
            // txtTarjetaVideo
            // 
            this.txtTarjetaVideo.Location = new System.Drawing.Point(12, 102);
            this.txtTarjetaVideo.Name = "txtTarjetaVideo";
            this.txtTarjetaVideo.Size = new System.Drawing.Size(100, 20);
            this.txtTarjetaVideo.TabIndex = 21;
            this.txtTarjetaVideo.TextChanged += new System.EventHandler(this.txtTarjetaVideo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tarjeta Video";
            // 
            // txtSSD
            // 
            this.txtSSD.Location = new System.Drawing.Point(11, 173);
            this.txtSSD.Name = "txtSSD";
            this.txtSSD.Size = new System.Drawing.Size(100, 20);
            this.txtSSD.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "SSD";
            // 
            // txtRGB
            // 
            this.txtRGB.Location = new System.Drawing.Point(12, 257);
            this.txtRGB.Name = "txtRGB";
            this.txtRGB.Size = new System.Drawing.Size(100, 20);
            this.txtRGB.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Luces gaming ";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(226, 387);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 26;
            // 
            // btnLimpiarTodo
            // 
            this.btnLimpiarTodo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpiarTodo.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarTodo.Location = new System.Drawing.Point(389, 299);
            this.btnLimpiarTodo.Name = "btnLimpiarTodo";
            this.btnLimpiarTodo.Size = new System.Drawing.Size(163, 69);
            this.btnLimpiarTodo.TabIndex = 27;
            this.btnLimpiarTodo.Text = "Limpiar todo";
            this.btnLimpiarTodo.UseVisualStyleBackColor = false;
            this.btnLimpiarTodo.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormularioPilas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpiarTodo);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtRGB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSSD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTarjetaVideo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMemoriaRam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_descendente_pila);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtEliminarCima);
            this.Controls.Add(this.btn_imprimir_pila);
            this.Controls.Add(this.btn_ascendente_pila);
            this.Controls.Add(this.btnAgregar);
            this.Name = "FormularioPilas";
            this.Text = "FormularioPilas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_descendente_pila;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button txtEliminarCima;
        private System.Windows.Forms.Button btn_imprimir_pila;
        private System.Windows.Forms.Button btn_ascendente_pila;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMemoriaRam;
        private System.Windows.Forms.TextBox txtTarjetaVideo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSSD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRGB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnLimpiarTodo;
    }
}