namespace ProyectoErik2023
{
    partial class FormularioColascs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioColascs));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiarCola = new System.Windows.Forms.Button();
            this.btn_imprimir_cola = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMemoriaRamCola = new System.Windows.Forms.TextBox();
            this.txtTarjetaCola = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRGBCola = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MemoriaRamColas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TarjetaVideoColas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SSDColas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RGBColas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtBuscarTarjetaCola = new System.Windows.Forms.TextBox();
            this.btnBuscarTarjeta = new System.Windows.Forms.Button();
            this.btnEnviarCambiosColas = new System.Windows.Forms.Button();
            this.boxSsdC = new System.Windows.Forms.ComboBox();
            this.btncerrarP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.Font = new System.Drawing.Font("SimSun", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Aqua;
            this.btnBuscar.Location = new System.Drawing.Point(170, 121);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(163, 69);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "Buscar Elemento";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiarCola
            // 
            this.btnLimpiarCola.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpiarCola.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiarCola.BackgroundImage")));
            this.btnLimpiarCola.Font = new System.Drawing.Font("SimSun", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCola.ForeColor = System.Drawing.Color.Aqua;
            this.btnLimpiarCola.Location = new System.Drawing.Point(686, 115);
            this.btnLimpiarCola.Name = "btnLimpiarCola";
            this.btnLimpiarCola.Size = new System.Drawing.Size(163, 69);
            this.btnLimpiarCola.TabIndex = 21;
            this.btnLimpiarCola.Text = "Eliminar";
            this.btnLimpiarCola.UseVisualStyleBackColor = false;
            this.btnLimpiarCola.Click += new System.EventHandler(this.btnLimpiarCola_Click);
            // 
            // btn_imprimir_cola
            // 
            this.btn_imprimir_cola.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_imprimir_cola.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_imprimir_cola.BackgroundImage")));
            this.btn_imprimir_cola.Font = new System.Drawing.Font("SimSun", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir_cola.ForeColor = System.Drawing.Color.Aqua;
            this.btn_imprimir_cola.Location = new System.Drawing.Point(686, 26);
            this.btn_imprimir_cola.Name = "btn_imprimir_cola";
            this.btn_imprimir_cola.Size = new System.Drawing.Size(163, 69);
            this.btn_imprimir_cola.TabIndex = 20;
            this.btn_imprimir_cola.Text = "Imprimir Cola";
            this.btn_imprimir_cola.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.Font = new System.Drawing.Font("SimSun", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Aqua;
            this.btnAgregar.Location = new System.Drawing.Point(170, 15);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(163, 69);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "Agregar Elemento";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Memoria ram";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMemoriaRamCola
            // 
            this.txtMemoriaRamCola.Location = new System.Drawing.Point(3, 40);
            this.txtMemoriaRamCola.Name = "txtMemoriaRamCola";
            this.txtMemoriaRamCola.Size = new System.Drawing.Size(100, 20);
            this.txtMemoriaRamCola.TabIndex = 25;
            // 
            // txtTarjetaCola
            // 
            this.txtTarjetaCola.Location = new System.Drawing.Point(2, 103);
            this.txtTarjetaCola.Name = "txtTarjetaCola";
            this.txtTarjetaCola.Size = new System.Drawing.Size(100, 20);
            this.txtTarjetaCola.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tarjeta de Video";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "SSD";
            // 
            // txtRGBCola
            // 
            this.txtRGBCola.Location = new System.Drawing.Point(2, 251);
            this.txtRGBCola.Name = "txtRGBCola";
            this.txtRGBCola.Size = new System.Drawing.Size(100, 20);
            this.txtRGBCola.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Luces gaming RGB";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MemoriaRamColas,
            this.TarjetaVideoColas,
            this.SSDColas,
            this.RGBColas});
            this.dataGridView1.Location = new System.Drawing.Point(518, 392);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(447, 150);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MemoriaRamColas
            // 
            this.MemoriaRamColas.HeaderText = "Memoria ram";
            this.MemoriaRamColas.Name = "MemoriaRamColas";
            this.MemoriaRamColas.ReadOnly = true;
            // 
            // TarjetaVideoColas
            // 
            this.TarjetaVideoColas.HeaderText = "Tarjeta de Video";
            this.TarjetaVideoColas.Name = "TarjetaVideoColas";
            this.TarjetaVideoColas.ReadOnly = true;
            // 
            // SSDColas
            // 
            this.SSDColas.HeaderText = "SSD";
            this.SSDColas.Name = "SSDColas";
            this.SSDColas.ReadOnly = true;
            // 
            // RGBColas
            // 
            this.RGBColas.HeaderText = "Luces gaming";
            this.RGBColas.Name = "RGBColas";
            this.RGBColas.ReadOnly = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(185, 216);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 33;
            // 
            // txtBuscarTarjetaCola
            // 
            this.txtBuscarTarjetaCola.Location = new System.Drawing.Point(767, 270);
            this.txtBuscarTarjetaCola.Name = "txtBuscarTarjetaCola";
            this.txtBuscarTarjetaCola.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarTarjetaCola.TabIndex = 34;
            this.txtBuscarTarjetaCola.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnBuscarTarjeta
            // 
            this.btnBuscarTarjeta.Location = new System.Drawing.Point(632, 206);
            this.btnBuscarTarjeta.Name = "btnBuscarTarjeta";
            this.btnBuscarTarjeta.Size = new System.Drawing.Size(107, 38);
            this.btnBuscarTarjeta.TabIndex = 35;
            this.btnBuscarTarjeta.Text = "Buscar tarjeta (editar)";
            this.btnBuscarTarjeta.UseVisualStyleBackColor = true;
            this.btnBuscarTarjeta.Click += new System.EventHandler(this.btnBuscarTarjeta_Click);
            // 
            // btnEnviarCambiosColas
            // 
            this.btnEnviarCambiosColas.Location = new System.Drawing.Point(736, 305);
            this.btnEnviarCambiosColas.Name = "btnEnviarCambiosColas";
            this.btnEnviarCambiosColas.Size = new System.Drawing.Size(141, 33);
            this.btnEnviarCambiosColas.TabIndex = 36;
            this.btnEnviarCambiosColas.Text = "Enviar cambios";
            this.btnEnviarCambiosColas.UseVisualStyleBackColor = true;
            this.btnEnviarCambiosColas.Click += new System.EventHandler(this.btnEnviarCambiosColas_Click);
            // 
            // boxSsdC
            // 
            this.boxSsdC.FormattingEnabled = true;
            this.boxSsdC.Items.AddRange(new object[] {
            "Toshiba 1Tb",
            "Kingston 512Mb",
            "Samsung 2Tb"});
            this.boxSsdC.Location = new System.Drawing.Point(3, 185);
            this.boxSsdC.Name = "boxSsdC";
            this.boxSsdC.Size = new System.Drawing.Size(136, 21);
            this.boxSsdC.TabIndex = 38;
            // 
            // btncerrarP
            // 
            this.btncerrarP.BackgroundImage = global::ProyectoErik2023.Properties.Resources.close_button_clip_art_f;
            this.btncerrarP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrarP.Location = new System.Drawing.Point(909, 13);
            this.btncerrarP.Name = "btncerrarP";
            this.btncerrarP.Size = new System.Drawing.Size(56, 50);
            this.btncerrarP.TabIndex = 40;
            this.btncerrarP.UseVisualStyleBackColor = true;
            this.btncerrarP.Click += new System.EventHandler(this.btncerrarP_Click);
            // 
            // FormularioColascs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoErik2023.Properties.Resources.john_wick_3_parabellum_3078;
            this.ClientSize = new System.Drawing.Size(977, 554);
            this.Controls.Add(this.btncerrarP);
            this.Controls.Add(this.boxSsdC);
            this.Controls.Add(this.btnEnviarCambiosColas);
            this.Controls.Add(this.btnBuscarTarjeta);
            this.Controls.Add(this.txtBuscarTarjetaCola);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtRGBCola);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTarjetaCola);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMemoriaRamCola);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiarCola);
            this.Controls.Add(this.btn_imprimir_cola);
            this.Controls.Add(this.btnAgregar);
            this.Name = "FormularioColascs";
            this.Text = "Enviar cambios";
            this.Load += new System.EventHandler(this.FormularioColascs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiarCola;
        private System.Windows.Forms.Button btn_imprimir_cola;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMemoriaRamCola;
        private System.Windows.Forms.TextBox txtTarjetaCola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRGBCola;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemoriaRamColas;
        private System.Windows.Forms.DataGridViewTextBoxColumn TarjetaVideoColas;
        private System.Windows.Forms.DataGridViewTextBoxColumn SSDColas;
        private System.Windows.Forms.DataGridViewTextBoxColumn RGBColas;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtBuscarTarjetaCola;
        private System.Windows.Forms.Button btnBuscarTarjeta;
        private System.Windows.Forms.Button btnEnviarCambiosColas;
        private System.Windows.Forms.ComboBox boxSsdC;
        private System.Windows.Forms.Button btncerrarP;
    }
}