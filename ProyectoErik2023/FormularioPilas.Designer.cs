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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPilas));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtEliminarCima = new System.Windows.Forms.Button();
            this.btn_imprimir_pila = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMemoriaRam = new System.Windows.Forms.TextBox();
            this.txtTarjetaVideo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRGB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnLimpiarTodo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.memoriaRam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarjetaVideo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RGB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.txtBuscarTarjetaEditar = new System.Windows.Forms.TextBox();
            this.btnBuscarTarjeta = new System.Windows.Forms.Button();
            this.btnEnviarCambiosCola = new System.Windows.Forms.Button();
            this.boxSsdP = new System.Windows.Forms.ComboBox();
            this.btncerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Aqua;
            this.btnBuscar.Location = new System.Drawing.Point(27, 438);
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
            this.txtEliminarCima.BackgroundImage = global::ProyectoErik2023.Properties.Resources._5ff1d8cf3bf975663f1be52421234fc4;
            this.txtEliminarCima.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEliminarCima.ForeColor = System.Drawing.Color.Aqua;
            this.txtEliminarCima.Location = new System.Drawing.Point(152, 102);
            this.txtEliminarCima.Name = "txtEliminarCima";
            this.txtEliminarCima.Size = new System.Drawing.Size(145, 83);
            this.txtEliminarCima.TabIndex = 15;
            this.txtEliminarCima.Text = "Eliminar cima";
            this.txtEliminarCima.UseVisualStyleBackColor = false;
            this.txtEliminarCima.Click += new System.EventHandler(this.txtEliminarCima_Click);
            // 
            // btn_imprimir_pila
            // 
            this.btn_imprimir_pila.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_imprimir_pila.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_imprimir_pila.BackgroundImage")));
            this.btn_imprimir_pila.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir_pila.ForeColor = System.Drawing.Color.Aqua;
            this.btn_imprimir_pila.Location = new System.Drawing.Point(885, 20);
            this.btn_imprimir_pila.Name = "btn_imprimir_pila";
            this.btn_imprimir_pila.Size = new System.Drawing.Size(163, 69);
            this.btn_imprimir_pila.TabIndex = 14;
            this.btn_imprimir_pila.Text = "Imprimir Pila";
            this.btn_imprimir_pila.UseVisualStyleBackColor = false;
            this.btn_imprimir_pila.Click += new System.EventHandler(this.btn_imprimir_pila_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.Font = new System.Drawing.Font("SimSun", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Aqua;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregar.Location = new System.Drawing.Point(152, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(145, 69);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar Elemento";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.agregar_elementoP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tarjeta Video";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "SSD";
            // 
            // txtRGB
            // 
            this.txtRGB.Location = new System.Drawing.Point(7, 266);
            this.txtRGB.Name = "txtRGB";
            this.txtRGB.Size = new System.Drawing.Size(100, 20);
            this.txtRGB.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Luces gaming ";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(215, 487);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 26;
            // 
            // btnLimpiarTodo
            // 
            this.btnLimpiarTodo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpiarTodo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiarTodo.BackgroundImage")));
            this.btnLimpiarTodo.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarTodo.ForeColor = System.Drawing.Color.Aqua;
            this.btnLimpiarTodo.Location = new System.Drawing.Point(976, 363);
            this.btnLimpiarTodo.Name = "btnLimpiarTodo";
            this.btnLimpiarTodo.Size = new System.Drawing.Size(163, 69);
            this.btnLimpiarTodo.TabIndex = 27;
            this.btnLimpiarTodo.Text = "Limpiar todo";
            this.btnLimpiarTodo.UseVisualStyleBackColor = false;
            this.btnLimpiarTodo.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memoriaRam,
            this.tarjetaVideo,
            this.SSD,
            this.RGB});
            this.dataGridView1.Location = new System.Drawing.Point(606, 465);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(542, 178);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // memoriaRam
            // 
            this.memoriaRam.HeaderText = "Memoria Ram";
            this.memoriaRam.Name = "memoriaRam";
            this.memoriaRam.ReadOnly = true;
            // 
            // tarjetaVideo
            // 
            this.tarjetaVideo.HeaderText = "Tarjeta de Video";
            this.tarjetaVideo.Name = "tarjetaVideo";
            this.tarjetaVideo.ReadOnly = true;
            // 
            // SSD
            // 
            this.SSD.HeaderText = "SSD";
            this.SSD.Name = "SSD";
            this.SSD.ReadOnly = true;
            // 
            // RGB
            // 
            this.RGB.HeaderText = "Luces gaming RGB";
            this.RGB.Name = "RGB";
            this.RGB.ReadOnly = true;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRefrescar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.BackgroundImage")));
            this.btnRefrescar.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.ForeColor = System.Drawing.Color.Aqua;
            this.btnRefrescar.Location = new System.Drawing.Point(27, 544);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(163, 69);
            this.btnRefrescar.TabIndex = 29;
            this.btnRefrescar.Text = "Refrescar Vista";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // txtBuscarTarjetaEditar
            // 
            this.txtBuscarTarjetaEditar.Location = new System.Drawing.Point(586, 363);
            this.txtBuscarTarjetaEditar.Name = "txtBuscarTarjetaEditar";
            this.txtBuscarTarjetaEditar.Size = new System.Drawing.Size(139, 20);
            this.txtBuscarTarjetaEditar.TabIndex = 30;
            this.txtBuscarTarjetaEditar.TextChanged += new System.EventHandler(this.txtBuscarTarjetaEditar_TextChanged);
            // 
            // btnBuscarTarjeta
            // 
            this.btnBuscarTarjeta.Location = new System.Drawing.Point(586, 395);
            this.btnBuscarTarjeta.Name = "btnBuscarTarjeta";
            this.btnBuscarTarjeta.Size = new System.Drawing.Size(159, 43);
            this.btnBuscarTarjeta.TabIndex = 31;
            this.btnBuscarTarjeta.Text = "Buscar tarjeta video";
            this.btnBuscarTarjeta.UseVisualStyleBackColor = true;
            this.btnBuscarTarjeta.Click += new System.EventHandler(this.btnBuscarTarjeta_Click);
            // 
            // btnEnviarCambiosCola
            // 
            this.btnEnviarCambiosCola.Location = new System.Drawing.Point(452, 389);
            this.btnEnviarCambiosCola.Name = "btnEnviarCambiosCola";
            this.btnEnviarCambiosCola.Size = new System.Drawing.Size(112, 49);
            this.btnEnviarCambiosCola.TabIndex = 32;
            this.btnEnviarCambiosCola.Text = "Enviar cambios";
            this.btnEnviarCambiosCola.UseVisualStyleBackColor = true;
            this.btnEnviarCambiosCola.Click += new System.EventHandler(this.btnEnviarCambiosCola_Click);
            // 
            // boxSsdP
            // 
            this.boxSsdP.FormattingEnabled = true;
            this.boxSsdP.Items.AddRange(new object[] {
            "Toshiba 1Tb",
            "Kingston 512Mb",
            "Samsung 2Tb"});
            this.boxSsdP.Location = new System.Drawing.Point(6, 187);
            this.boxSsdP.Name = "boxSsdP";
            this.boxSsdP.Size = new System.Drawing.Size(136, 21);
            this.boxSsdP.TabIndex = 37;
            // 
            // btncerrar
            // 
            this.btncerrar.BackgroundImage = global::ProyectoErik2023.Properties.Resources.close_button_clip_art_f;
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Location = new System.Drawing.Point(1151, 12);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(56, 50);
            this.btncerrar.TabIndex = 40;
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // FormularioPilas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoErik2023.Properties.Resources.Morgana_0;
            this.ClientSize = new System.Drawing.Size(1219, 655);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.boxSsdP);
            this.Controls.Add(this.btnEnviarCambiosCola);
            this.Controls.Add(this.btnBuscarTarjeta);
            this.Controls.Add(this.txtBuscarTarjetaEditar);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLimpiarTodo);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtRGB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTarjetaVideo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMemoriaRam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtEliminarCima);
            this.Controls.Add(this.btn_imprimir_pila);
            this.Name = "FormularioPilas";
            this.Text = "FormularioPilas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button txtEliminarCima;
        private System.Windows.Forms.Button btn_imprimir_pila;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMemoriaRam;
        private System.Windows.Forms.TextBox txtTarjetaVideo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRGB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnLimpiarTodo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoriaRam;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarjetaVideo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn RGB;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.TextBox txtBuscarTarjetaEditar;
        private System.Windows.Forms.Button btnBuscarTarjeta;
        private System.Windows.Forms.Button btnEnviarCambiosCola;
        private System.Windows.Forms.ComboBox boxSsdP;
        private System.Windows.Forms.Button btncerrar;
    }
}