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
            this.btn_descendente_cola = new System.Windows.Forms.Button();
            this.btnBuscarCola = new System.Windows.Forms.Button();
            this.limpia_cola = new System.Windows.Forms.Button();
            this.btn_imprimir_cola = new System.Windows.Forms.Button();
            this.btn_ascendente_cola = new System.Windows.Forms.Button();
            this.btnAgregarCola = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMemoriaRamCola = new System.Windows.Forms.TextBox();
            this.btnTarjetaCola = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSSDCola = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRGB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MemoriaRamColas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TarjetaCola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SSDColas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RGBColas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarCola = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_descendente_cola
            // 
            this.btn_descendente_cola.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_descendente_cola.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_descendente_cola.Location = new System.Drawing.Point(451, 231);
            this.btn_descendente_cola.Margin = new System.Windows.Forms.Padding(4);
            this.btn_descendente_cola.Name = "btn_descendente_cola";
            this.btn_descendente_cola.Size = new System.Drawing.Size(217, 85);
            this.btn_descendente_cola.TabIndex = 23;
            this.btn_descendente_cola.Text = "Ordenar Descendente";
            this.btn_descendente_cola.UseVisualStyleBackColor = false;
            this.btn_descendente_cola.Click += new System.EventHandler(this.btn_descendente_cola_Click);
            // 
            // btnBuscarCola
            // 
            this.btnBuscarCola.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscarCola.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCola.Location = new System.Drawing.Point(13, 388);
            this.btnBuscarCola.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCola.Name = "btnBuscarCola";
            this.btnBuscarCola.Size = new System.Drawing.Size(217, 85);
            this.btnBuscarCola.TabIndex = 22;
            this.btnBuscarCola.Text = "Buscar Elemento";
            this.btnBuscarCola.UseVisualStyleBackColor = false;
            this.btnBuscarCola.Click += new System.EventHandler(this.btnBuscarCola_Click);
            // 
            // limpia_cola
            // 
            this.limpia_cola.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.limpia_cola.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpia_cola.Location = new System.Drawing.Point(723, 212);
            this.limpia_cola.Margin = new System.Windows.Forms.Padding(4);
            this.limpia_cola.Name = "limpia_cola";
            this.limpia_cola.Size = new System.Drawing.Size(217, 85);
            this.limpia_cola.TabIndex = 21;
            this.limpia_cola.Text = "Limpiar Cola";
            this.limpia_cola.UseVisualStyleBackColor = false;
            this.limpia_cola.Click += new System.EventHandler(this.limpia_cola_Click);
            // 
            // btn_imprimir_cola
            // 
            this.btn_imprimir_cola.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_imprimir_cola.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir_cola.Location = new System.Drawing.Point(808, 88);
            this.btn_imprimir_cola.Margin = new System.Windows.Forms.Padding(4);
            this.btn_imprimir_cola.Name = "btn_imprimir_cola";
            this.btn_imprimir_cola.Size = new System.Drawing.Size(217, 85);
            this.btn_imprimir_cola.TabIndex = 20;
            this.btn_imprimir_cola.Text = "Eliminar elemento";
            this.btn_imprimir_cola.UseVisualStyleBackColor = false;
            this.btn_imprimir_cola.Click += new System.EventHandler(this.btn_imprimir_cola_Click);
            // 
            // btn_ascendente_cola
            // 
            this.btn_ascendente_cola.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ascendente_cola.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ascendente_cola.Location = new System.Drawing.Point(583, -5);
            this.btn_ascendente_cola.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ascendente_cola.Name = "btn_ascendente_cola";
            this.btn_ascendente_cola.Size = new System.Drawing.Size(217, 85);
            this.btn_ascendente_cola.TabIndex = 19;
            this.btn_ascendente_cola.Text = "Ordenar Ascendente";
            this.btn_ascendente_cola.UseVisualStyleBackColor = false;
            this.btn_ascendente_cola.Click += new System.EventHandler(this.btn_ascendente_cola_Click);
            // 
            // btnAgregarCola
            // 
            this.btnAgregarCola.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregarCola.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCola.Location = new System.Drawing.Point(167, 13);
            this.btnAgregarCola.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarCola.Name = "btnAgregarCola";
            this.btnAgregarCola.Size = new System.Drawing.Size(217, 85);
            this.btnAgregarCola.TabIndex = 18;
            this.btnAgregarCola.Text = "Agregar Elemento";
            this.btnAgregarCola.UseVisualStyleBackColor = false;
            this.btnAgregarCola.Click += new System.EventHandler(this.btnAgregarCola_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Memoria Ram";
            // 
            // txtMemoriaRamCola
            // 
            this.txtMemoriaRamCola.Location = new System.Drawing.Point(1, 45);
            this.txtMemoriaRamCola.Name = "txtMemoriaRamCola";
            this.txtMemoriaRamCola.Size = new System.Drawing.Size(100, 22);
            this.txtMemoriaRamCola.TabIndex = 25;
            // 
            // btnTarjetaCola
            // 
            this.btnTarjetaCola.Location = new System.Drawing.Point(15, 137);
            this.btnTarjetaCola.Name = "btnTarjetaCola";
            this.btnTarjetaCola.Size = new System.Drawing.Size(100, 22);
            this.btnTarjetaCola.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tarjeta de video";
            // 
            // txtSSDCola
            // 
            this.txtSSDCola.Location = new System.Drawing.Point(1, 244);
            this.txtSSDCola.Name = "txtSSDCola";
            this.txtSSDCola.Size = new System.Drawing.Size(100, 22);
            this.txtSSDCola.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "SSD";
            // 
            // txtRGB
            // 
            this.txtRGB.Location = new System.Drawing.Point(1, 345);
            this.txtRGB.Name = "txtRGB";
            this.txtRGB.Size = new System.Drawing.Size(100, 22);
            this.txtRGB.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "RGB";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MemoriaRamColas,
            this.TarjetaCola,
            this.SSDColas,
            this.RGBColas});
            this.dataGridView1.Location = new System.Drawing.Point(322, 345);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(544, 150);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MemoriaRamColas
            // 
            this.MemoriaRamColas.HeaderText = "Tarjeta de Video";
            this.MemoriaRamColas.MinimumWidth = 6;
            this.MemoriaRamColas.Name = "MemoriaRamColas";
            this.MemoriaRamColas.ReadOnly = true;
            this.MemoriaRamColas.Width = 125;
            // 
            // TarjetaCola
            // 
            this.TarjetaCola.HeaderText = "Memoria Ram";
            this.TarjetaCola.MinimumWidth = 6;
            this.TarjetaCola.Name = "TarjetaCola";
            this.TarjetaCola.ReadOnly = true;
            this.TarjetaCola.Width = 125;
            // 
            // SSDColas
            // 
            this.SSDColas.HeaderText = "SSD";
            this.SSDColas.MinimumWidth = 6;
            this.SSDColas.Name = "SSDColas";
            this.SSDColas.ReadOnly = true;
            this.SSDColas.Width = 125;
            // 
            // RGBColas
            // 
            this.RGBColas.HeaderText = "Luces Gaming";
            this.RGBColas.MinimumWidth = 6;
            this.RGBColas.Name = "RGBColas";
            this.RGBColas.ReadOnly = true;
            this.RGBColas.Width = 125;
            // 
            // txtBuscarCola
            // 
            this.txtBuscarCola.Location = new System.Drawing.Point(41, 498);
            this.txtBuscarCola.Name = "txtBuscarCola";
            this.txtBuscarCola.Size = new System.Drawing.Size(100, 22);
            this.txtBuscarCola.TabIndex = 33;
            // 
            // FormularioColascs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtBuscarCola);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtRGB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSSDCola);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTarjetaCola);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMemoriaRamCola);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_descendente_cola);
            this.Controls.Add(this.btnBuscarCola);
            this.Controls.Add(this.limpia_cola);
            this.Controls.Add(this.btn_imprimir_cola);
            this.Controls.Add(this.btn_ascendente_cola);
            this.Controls.Add(this.btnAgregarCola);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormularioColascs";
            this.Text = "FormularioColascs";
            this.Load += new System.EventHandler(this.FormularioColascs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_descendente_cola;
        private System.Windows.Forms.Button btnBuscarCola;
        private System.Windows.Forms.Button limpia_cola;
        private System.Windows.Forms.Button btn_imprimir_cola;
        private System.Windows.Forms.Button btn_ascendente_cola;
        private System.Windows.Forms.Button btnAgregarCola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMemoriaRamCola;
        private System.Windows.Forms.TextBox btnTarjetaCola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSSDCola;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRGB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemoriaRamColas;
        private System.Windows.Forms.DataGridViewTextBoxColumn TarjetaCola;
        private System.Windows.Forms.DataGridViewTextBoxColumn SSDColas;
        private System.Windows.Forms.DataGridViewTextBoxColumn RGBColas;
        private System.Windows.Forms.TextBox txtBuscarCola;
    }
}