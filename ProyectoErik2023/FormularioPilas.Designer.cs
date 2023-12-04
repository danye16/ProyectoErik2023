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
            this.btn_buscar_elementoP = new System.Windows.Forms.Button();
            this.limpia_pila = new System.Windows.Forms.Button();
            this.btn_imprimir_pila = new System.Windows.Forms.Button();
            this.btn_ascendente_pila = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.memoriaRam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarjetaVideo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RGB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmemoriaRam = new System.Windows.Forms.TextBox();
            this.txtTarjetaVideo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSSD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRGB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_descendente_pila
            // 
            this.btn_descendente_pila.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_descendente_pila.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_descendente_pila.Location = new System.Drawing.Point(606, 264);
            this.btn_descendente_pila.Name = "btn_descendente_pila";
            this.btn_descendente_pila.Size = new System.Drawing.Size(163, 69);
            this.btn_descendente_pila.TabIndex = 17;
            this.btn_descendente_pila.Text = "Ordenar Descendente";
            this.btn_descendente_pila.UseVisualStyleBackColor = false;
            // 
            // btn_buscar_elementoP
            // 
            this.btn_buscar_elementoP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_buscar_elementoP.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar_elementoP.Location = new System.Drawing.Point(606, 198);
            this.btn_buscar_elementoP.Name = "btn_buscar_elementoP";
            this.btn_buscar_elementoP.Size = new System.Drawing.Size(163, 69);
            this.btn_buscar_elementoP.TabIndex = 16;
            this.btn_buscar_elementoP.Text = "Buscar Elemento";
            this.btn_buscar_elementoP.UseVisualStyleBackColor = false;
            // 
            // limpia_pila
            // 
            this.limpia_pila.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.limpia_pila.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpia_pila.Location = new System.Drawing.Point(606, 339);
            this.limpia_pila.Name = "limpia_pila";
            this.limpia_pila.Size = new System.Drawing.Size(163, 69);
            this.limpia_pila.TabIndex = 15;
            this.limpia_pila.Text = "Limpiar Pila";
            this.limpia_pila.UseVisualStyleBackColor = false;
            // 
            // btn_imprimir_pila
            // 
            this.btn_imprimir_pila.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_imprimir_pila.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir_pila.Location = new System.Drawing.Point(606, 54);
            this.btn_imprimir_pila.Name = "btn_imprimir_pila";
            this.btn_imprimir_pila.Size = new System.Drawing.Size(163, 69);
            this.btn_imprimir_pila.TabIndex = 14;
            this.btn_imprimir_pila.Text = "Imprimir Pila";
            this.btn_imprimir_pila.UseVisualStyleBackColor = false;
            // 
            // btn_ascendente_pila
            // 
            this.btn_ascendente_pila.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ascendente_pila.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ascendente_pila.Location = new System.Drawing.Point(606, 114);
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
            this.btnAgregar.Location = new System.Drawing.Point(241, 110);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(163, 69);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar Elemento";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memoriaRam,
            this.tarjetaVideo,
            this.SSD,
            this.RGB});
            this.dataGridView1.Location = new System.Drawing.Point(12, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(565, 150);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // memoriaRam
            // 
            this.memoriaRam.HeaderText = "Memoria Ram";
            this.memoriaRam.Name = "memoriaRam";
            // 
            // tarjetaVideo
            // 
            this.tarjetaVideo.HeaderText = "Tarjeta de video";
            this.tarjetaVideo.Name = "tarjetaVideo";
            // 
            // SSD
            // 
            this.SSD.HeaderText = "SSD";
            this.SSD.Name = "SSD";
            // 
            // RGB
            // 
            this.RGB.HeaderText = "Luces gaming";
            this.RGB.Name = "RGB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Memoria ram";
            // 
            // txtmemoriaRam
            // 
            this.txtmemoriaRam.Location = new System.Drawing.Point(32, 41);
            this.txtmemoriaRam.Name = "txtmemoriaRam";
            this.txtmemoriaRam.Size = new System.Drawing.Size(100, 20);
            this.txtmemoriaRam.TabIndex = 20;
            // 
            // txtTarjetaVideo
            // 
            this.txtTarjetaVideo.Location = new System.Drawing.Point(32, 110);
            this.txtTarjetaVideo.Name = "txtTarjetaVideo";
            this.txtTarjetaVideo.Size = new System.Drawing.Size(100, 20);
            this.txtTarjetaVideo.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tarjeta Video";
            // 
            // txtSSD
            // 
            this.txtSSD.Location = new System.Drawing.Point(32, 170);
            this.txtSSD.Name = "txtSSD";
            this.txtSSD.Size = new System.Drawing.Size(100, 20);
            this.txtSSD.TabIndex = 24;
            this.txtSSD.TextChanged += new System.EventHandler(this.txtSSD_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "SSD";
            // 
            // txtRGB
            // 
            this.txtRGB.Location = new System.Drawing.Point(32, 254);
            this.txtRGB.Name = "txtRGB";
            this.txtRGB.Size = new System.Drawing.Size(100, 20);
            this.txtRGB.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Luces gaming";
            // 
            // FormularioPilas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRGB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSSD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTarjetaVideo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmemoriaRam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_descendente_pila);
            this.Controls.Add(this.btn_buscar_elementoP);
            this.Controls.Add(this.limpia_pila);
            this.Controls.Add(this.btn_imprimir_pila);
            this.Controls.Add(this.btn_ascendente_pila);
            this.Controls.Add(this.btnAgregar);
            this.Name = "FormularioPilas";
            this.Text = "FormularioPilas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_descendente_pila;
        private System.Windows.Forms.Button btn_buscar_elementoP;
        private System.Windows.Forms.Button limpia_pila;
        private System.Windows.Forms.Button btn_imprimir_pila;
        private System.Windows.Forms.Button btn_ascendente_pila;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoriaRam;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarjetaVideo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn RGB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmemoriaRam;
        private System.Windows.Forms.TextBox txtTarjetaVideo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSSD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRGB;
        private System.Windows.Forms.Label label4;
    }
}