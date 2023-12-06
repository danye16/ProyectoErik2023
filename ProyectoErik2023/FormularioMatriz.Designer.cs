namespace ProyectoErik2023
{
    partial class FormularioMatriz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioMatriz));
            this.btn_descendente_listaM = new System.Windows.Forms.Button();
            this.btn_buscar_listaM = new System.Windows.Forms.Button();
            this.limpia_listaM = new System.Windows.Forms.Button();
            this.btn_imprimir_listaM = new System.Windows.Forms.Button();
            this.btn_ascendente_listaM = new System.Windows.Forms.Button();
            this.agregar_elementoM = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.memoriaRam = new System.Windows.Forms.TextBox();
            this.txtTarjetaVideo = new System.Windows.Forms.TextBox();
            this.txtSSD = new System.Windows.Forms.TextBox();
            this.txtRGB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.btnInsertarfinal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.memoriaRamMatriz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TarjetaVideoMatriz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SSDMatriz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RGBMatriz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefrescar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_descendente_listaM
            // 
            this.btn_descendente_listaM.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_descendente_listaM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_descendente_listaM.BackgroundImage")));
            this.btn_descendente_listaM.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_descendente_listaM.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_descendente_listaM.Location = new System.Drawing.Point(211, 21);
            this.btn_descendente_listaM.Name = "btn_descendente_listaM";
            this.btn_descendente_listaM.Size = new System.Drawing.Size(163, 69);
            this.btn_descendente_listaM.TabIndex = 11;
            this.btn_descendente_listaM.Text = "Ordenar Descendente";
            this.btn_descendente_listaM.UseVisualStyleBackColor = false;
            this.btn_descendente_listaM.Click += new System.EventHandler(this.btn_descendente_listaM_Click);
            // 
            // btn_buscar_listaM
            // 
            this.btn_buscar_listaM.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_buscar_listaM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar_listaM.BackgroundImage")));
            this.btn_buscar_listaM.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar_listaM.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_buscar_listaM.Location = new System.Drawing.Point(190, 332);
            this.btn_buscar_listaM.Name = "btn_buscar_listaM";
            this.btn_buscar_listaM.Size = new System.Drawing.Size(163, 69);
            this.btn_buscar_listaM.TabIndex = 10;
            this.btn_buscar_listaM.Text = "Buscar Elemento";
            this.btn_buscar_listaM.UseVisualStyleBackColor = false;
            this.btn_buscar_listaM.Click += new System.EventHandler(this.btn_buscar_listaM_Click);
            // 
            // limpia_listaM
            // 
            this.limpia_listaM.BackColor = System.Drawing.Color.DarkBlue;
            this.limpia_listaM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("limpia_listaM.BackgroundImage")));
            this.limpia_listaM.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpia_listaM.ForeColor = System.Drawing.SystemColors.Control;
            this.limpia_listaM.Location = new System.Drawing.Point(211, 105);
            this.limpia_listaM.Name = "limpia_listaM";
            this.limpia_listaM.Size = new System.Drawing.Size(163, 69);
            this.limpia_listaM.TabIndex = 9;
            this.limpia_listaM.Text = "Limpiar Lista";
            this.limpia_listaM.UseVisualStyleBackColor = false;
            this.limpia_listaM.Click += new System.EventHandler(this.limpia_listaM_Click);
            // 
            // btn_imprimir_listaM
            // 
            this.btn_imprimir_listaM.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_imprimir_listaM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_imprimir_listaM.BackgroundImage")));
            this.btn_imprimir_listaM.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir_listaM.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_imprimir_listaM.Location = new System.Drawing.Point(428, 21);
            this.btn_imprimir_listaM.Name = "btn_imprimir_listaM";
            this.btn_imprimir_listaM.Size = new System.Drawing.Size(163, 69);
            this.btn_imprimir_listaM.TabIndex = 8;
            this.btn_imprimir_listaM.Text = "Imprimir Lista";
            this.btn_imprimir_listaM.UseVisualStyleBackColor = false;
            this.btn_imprimir_listaM.Click += new System.EventHandler(this.btn_imprimir_listaM_Click);
            // 
            // btn_ascendente_listaM
            // 
            this.btn_ascendente_listaM.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_ascendente_listaM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ascendente_listaM.BackgroundImage")));
            this.btn_ascendente_listaM.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ascendente_listaM.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_ascendente_listaM.Location = new System.Drawing.Point(211, 229);
            this.btn_ascendente_listaM.Name = "btn_ascendente_listaM";
            this.btn_ascendente_listaM.Size = new System.Drawing.Size(163, 69);
            this.btn_ascendente_listaM.TabIndex = 7;
            this.btn_ascendente_listaM.Text = "Ordenar Ascendente";
            this.btn_ascendente_listaM.UseVisualStyleBackColor = false;
            this.btn_ascendente_listaM.Click += new System.EventHandler(this.btn_ascendente_listaM_Click);
            // 
            // agregar_elementoM
            // 
            this.agregar_elementoM.BackColor = System.Drawing.Color.DarkBlue;
            this.agregar_elementoM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("agregar_elementoM.BackgroundImage")));
            this.agregar_elementoM.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar_elementoM.ForeColor = System.Drawing.SystemColors.Control;
            this.agregar_elementoM.Location = new System.Drawing.Point(31, 54);
            this.agregar_elementoM.Name = "agregar_elementoM";
            this.agregar_elementoM.Size = new System.Drawing.Size(163, 69);
            this.agregar_elementoM.TabIndex = 6;
            this.agregar_elementoM.Text = "Agregar Elemento";
            this.agregar_elementoM.UseVisualStyleBackColor = false;
            this.agregar_elementoM.Click += new System.EventHandler(this.agregar_elementoM_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 12;
            // 
            // memoriaRam
            // 
            this.memoriaRam.AccessibleName = "";
            this.memoriaRam.Location = new System.Drawing.Point(46, 202);
            this.memoriaRam.Name = "memoriaRam";
            this.memoriaRam.Size = new System.Drawing.Size(136, 20);
            this.memoriaRam.TabIndex = 13;
            this.memoriaRam.TextChanged += new System.EventHandler(this.memoriaRam_TextChanged);
            // 
            // txtTarjetaVideo
            // 
            this.txtTarjetaVideo.Location = new System.Drawing.Point(46, 260);
            this.txtTarjetaVideo.Name = "txtTarjetaVideo";
            this.txtTarjetaVideo.Size = new System.Drawing.Size(136, 20);
            this.txtTarjetaVideo.TabIndex = 14;
            this.txtTarjetaVideo.TextChanged += new System.EventHandler(this.txtTarjetaVideo_TextChanged);
            // 
            // txtSSD
            // 
            this.txtSSD.Location = new System.Drawing.Point(46, 309);
            this.txtSSD.Name = "txtSSD";
            this.txtSSD.Size = new System.Drawing.Size(136, 20);
            this.txtSSD.TabIndex = 15;
            // 
            // txtRGB
            // 
            this.txtRGB.Location = new System.Drawing.Point(46, 385);
            this.txtRGB.Name = "txtRGB";
            this.txtRGB.Size = new System.Drawing.Size(136, 20);
            this.txtRGB.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Memoria Ram";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tarjeta de video";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "SSD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Luces gaming RGB";
            // 
            // textBuscar
            // 
            this.textBuscar.AccessibleName = "";
            this.textBuscar.Location = new System.Drawing.Point(211, 426);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(136, 20);
            this.textBuscar.TabIndex = 25;
            // 
            // btnInsertarfinal
            // 
            this.btnInsertarfinal.BackColor = System.Drawing.Color.DarkBlue;
            this.btnInsertarfinal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInsertarfinal.BackgroundImage")));
            this.btnInsertarfinal.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarfinal.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInsertarfinal.Location = new System.Drawing.Point(31, 411);
            this.btnInsertarfinal.Name = "btnInsertarfinal";
            this.btnInsertarfinal.Size = new System.Drawing.Size(163, 69);
            this.btnInsertarfinal.TabIndex = 26;
            this.btnInsertarfinal.Text = "Agregar al Final";
            this.btnInsertarfinal.UseVisualStyleBackColor = false;
            this.btnInsertarfinal.Click += new System.EventHandler(this.btnInsertarfinal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoErik2023.Properties.Resources.intento;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -102);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(814, 707);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memoriaRamMatriz,
            this.TarjetaVideoMatriz,
            this.SSDMatriz,
            this.RGBMatriz});
            this.dataGridView1.Location = new System.Drawing.Point(359, 327);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(450, 150);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // memoriaRamMatriz
            // 
            this.memoriaRamMatriz.HeaderText = "Memoria Ram";
            this.memoriaRamMatriz.Name = "memoriaRamMatriz";
            this.memoriaRamMatriz.ReadOnly = true;
            // 
            // TarjetaVideoMatriz
            // 
            this.TarjetaVideoMatriz.HeaderText = "Tarjeta de Video";
            this.TarjetaVideoMatriz.Name = "TarjetaVideoMatriz";
            this.TarjetaVideoMatriz.ReadOnly = true;
            // 
            // SSDMatriz
            // 
            this.SSDMatriz.HeaderText = "SSD";
            this.SSDMatriz.Name = "SSDMatriz";
            this.SSDMatriz.ReadOnly = true;
            // 
            // RGBMatriz
            // 
            this.RGBMatriz.HeaderText = "Luces gaming ";
            this.RGBMatriz.Name = "RGBMatriz";
            this.RGBMatriz.ReadOnly = true;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.DarkBlue;
            this.btnRefrescar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.BackgroundImage")));
            this.btnRefrescar.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRefrescar.Location = new System.Drawing.Point(415, 142);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(163, 69);
            this.btnRefrescar.TabIndex = 29;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // FormularioMatriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnInsertarfinal);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRGB);
            this.Controls.Add(this.txtSSD);
            this.Controls.Add(this.txtTarjetaVideo);
            this.Controls.Add(this.memoriaRam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_descendente_listaM);
            this.Controls.Add(this.btn_buscar_listaM);
            this.Controls.Add(this.limpia_listaM);
            this.Controls.Add(this.btn_imprimir_listaM);
            this.Controls.Add(this.btn_ascendente_listaM);
            this.Controls.Add(this.agregar_elementoM);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "FormularioMatriz";
            this.Text = "FormularioMatriz";
            this.Load += new System.EventHandler(this.FormularioMatriz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_descendente_listaM;
        private System.Windows.Forms.Button btn_buscar_listaM;
        private System.Windows.Forms.Button limpia_listaM;
        private System.Windows.Forms.Button btn_imprimir_listaM;
        private System.Windows.Forms.Button btn_ascendente_listaM;
        private System.Windows.Forms.Button agregar_elementoM;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox memoriaRam;
        public System.Windows.Forms.TextBox txtTarjetaVideo;
        public System.Windows.Forms.TextBox txtSSD;
        public System.Windows.Forms.TextBox txtRGB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.Button btnInsertarfinal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoriaRamMatriz;
        private System.Windows.Forms.DataGridViewTextBoxColumn TarjetaVideoMatriz;
        private System.Windows.Forms.DataGridViewTextBoxColumn SSDMatriz;
        private System.Windows.Forms.DataGridViewTextBoxColumn RGBMatriz;
        private System.Windows.Forms.Button btnRefrescar;
    }
}

