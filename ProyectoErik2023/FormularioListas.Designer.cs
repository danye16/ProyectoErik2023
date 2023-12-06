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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRGBList = new System.Windows.Forms.TextBox();
            this.txtSSDList = new System.Windows.Forms.TextBox();
            this.txtTarjetaVideoList = new System.Windows.Forms.TextBox();
            this.memoriaRamList = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarList = new System.Windows.Forms.TextBox();
            this.InsertarMedioList = new System.Windows.Forms.Button();
            this.btn_InsertarFinal = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEliminarFrenteLista = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MemoriaRamListas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TarjetaVideoLista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SSDListas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RGBListas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // agregar_elemento
            // 
            this.agregar_elemento.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.agregar_elemento.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar_elemento.Location = new System.Drawing.Point(12, 12);
            this.agregar_elemento.Name = "agregar_elemento";
            this.agregar_elemento.Size = new System.Drawing.Size(163, 69);
            this.agregar_elemento.TabIndex = 0;
            this.agregar_elemento.Text = "Agregar Elemento";
            this.agregar_elemento.UseVisualStyleBackColor = false;
            this.agregar_elemento.Click += new System.EventHandler(this.agregar_elemento_Click);
            // 
            // btn_ascendente_lista
            // 
            this.btn_ascendente_lista.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ascendente_lista.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ascendente_lista.Location = new System.Drawing.Point(652, 193);
            this.btn_ascendente_lista.Name = "btn_ascendente_lista";
            this.btn_ascendente_lista.Size = new System.Drawing.Size(163, 69);
            this.btn_ascendente_lista.TabIndex = 1;
            this.btn_ascendente_lista.Text = "Ordenar Ascendente";
            this.btn_ascendente_lista.UseVisualStyleBackColor = false;
            this.btn_ascendente_lista.Click += new System.EventHandler(this.btn_ascendente_lista_Click);
            // 
            // btn_imprimir_lista
            // 
            this.btn_imprimir_lista.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_imprimir_lista.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir_lista.Location = new System.Drawing.Point(12, 193);
            this.btn_imprimir_lista.Name = "btn_imprimir_lista";
            this.btn_imprimir_lista.Size = new System.Drawing.Size(163, 69);
            this.btn_imprimir_lista.TabIndex = 2;
            this.btn_imprimir_lista.Text = "Imprimir Lista";
            this.btn_imprimir_lista.UseVisualStyleBackColor = false;
            this.btn_imprimir_lista.Click += new System.EventHandler(this.btn_imprimir_lista_Click);
            // 
            // limpia_lista
            // 
            this.limpia_lista.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.limpia_lista.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpia_lista.Location = new System.Drawing.Point(12, 279);
            this.limpia_lista.Name = "limpia_lista";
            this.limpia_lista.Size = new System.Drawing.Size(163, 69);
            this.limpia_lista.TabIndex = 3;
            this.limpia_lista.Text = "Limpiar Lista";
            this.limpia_lista.UseVisualStyleBackColor = false;
            this.limpia_lista.Click += new System.EventHandler(this.limpia_lista_Click);
            // 
            // btn_buscar_lista
            // 
            this.btn_buscar_lista.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_buscar_lista.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar_lista.Location = new System.Drawing.Point(12, 369);
            this.btn_buscar_lista.Name = "btn_buscar_lista";
            this.btn_buscar_lista.Size = new System.Drawing.Size(163, 69);
            this.btn_buscar_lista.TabIndex = 4;
            this.btn_buscar_lista.Text = "Buscar Elemento";
            this.btn_buscar_lista.UseVisualStyleBackColor = false;
            this.btn_buscar_lista.Click += new System.EventHandler(this.btn_buscar_lista_Click);
            // 
            // btn_descendente_lista
            // 
            this.btn_descendente_lista.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_descendente_lista.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_descendente_lista.Location = new System.Drawing.Point(652, 369);
            this.btn_descendente_lista.Name = "btn_descendente_lista";
            this.btn_descendente_lista.Size = new System.Drawing.Size(163, 69);
            this.btn_descendente_lista.TabIndex = 5;
            this.btn_descendente_lista.Text = "Ordenar Descendente";
            this.btn_descendente_lista.UseVisualStyleBackColor = false;
            this.btn_descendente_lista.Click += new System.EventHandler(this.btn_descendente_lista_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(677, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Luces gaming RGB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(541, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "SSD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkRed;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(377, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Tarjeta de video";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(225, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Memoria Ram";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtRGBList
            // 
            this.txtRGBList.Location = new System.Drawing.Point(670, 61);
            this.txtRGBList.Name = "txtRGBList";
            this.txtRGBList.Size = new System.Drawing.Size(136, 20);
            this.txtRGBList.TabIndex = 25;
            // 
            // txtSSDList
            // 
            this.txtSSDList.Location = new System.Drawing.Point(501, 61);
            this.txtSSDList.Name = "txtSSDList";
            this.txtSSDList.Size = new System.Drawing.Size(136, 20);
            this.txtSSDList.TabIndex = 24;
            // 
            // txtTarjetaVideoList
            // 
            this.txtTarjetaVideoList.Location = new System.Drawing.Point(348, 61);
            this.txtTarjetaVideoList.Name = "txtTarjetaVideoList";
            this.txtTarjetaVideoList.Size = new System.Drawing.Size(136, 20);
            this.txtTarjetaVideoList.TabIndex = 23;
            // 
            // memoriaRamList
            // 
            this.memoriaRamList.AccessibleName = "";
            this.memoriaRamList.Location = new System.Drawing.Point(193, 61);
            this.memoriaRamList.Name = "memoriaRamList";
            this.memoriaRamList.Size = new System.Drawing.Size(136, 20);
            this.memoriaRamList.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 21;
            // 
            // txtBuscarList
            // 
            this.txtBuscarList.Location = new System.Drawing.Point(204, 403);
            this.txtBuscarList.Name = "txtBuscarList";
            this.txtBuscarList.Size = new System.Drawing.Size(136, 20);
            this.txtBuscarList.TabIndex = 30;
            // 
            // InsertarMedioList
            // 
            this.InsertarMedioList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InsertarMedioList.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertarMedioList.Location = new System.Drawing.Point(652, 103);
            this.InsertarMedioList.Name = "InsertarMedioList";
            this.InsertarMedioList.Size = new System.Drawing.Size(163, 69);
            this.InsertarMedioList.TabIndex = 31;
            this.InsertarMedioList.Text = "Insertar Medio";
            this.InsertarMedioList.UseVisualStyleBackColor = false;
            this.InsertarMedioList.Click += new System.EventHandler(this.InsertarMedioList_Click);
            // 
            // btn_InsertarFinal
            // 
            this.btn_InsertarFinal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_InsertarFinal.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InsertarFinal.Location = new System.Drawing.Point(12, 103);
            this.btn_InsertarFinal.Name = "btn_InsertarFinal";
            this.btn_InsertarFinal.Size = new System.Drawing.Size(163, 69);
            this.btn_InsertarFinal.TabIndex = 32;
            this.btn_InsertarFinal.Text = "Insertar al final";
            this.btn_InsertarFinal.UseVisualStyleBackColor = false;
            this.btn_InsertarFinal.Click += new System.EventHandler(this.btn_InsertarFinal_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkRed;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(181, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Introduce el modelo de tarjeta de video";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnEliminarFrenteLista
            // 
            this.btnEliminarFrenteLista.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEliminarFrenteLista.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarFrenteLista.Location = new System.Drawing.Point(652, 279);
            this.btnEliminarFrenteLista.Name = "btnEliminarFrenteLista";
            this.btnEliminarFrenteLista.Size = new System.Drawing.Size(163, 69);
            this.btnEliminarFrenteLista.TabIndex = 34;
            this.btnEliminarFrenteLista.Text = "Eliminar Frente";
            this.btnEliminarFrenteLista.UseVisualStyleBackColor = false;
            this.btnEliminarFrenteLista.Click += new System.EventHandler(this.btnEliminarFrenteLista_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoErik2023.Properties.Resources.listaimagen;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(874, 471);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MemoriaRamListas,
            this.TarjetaVideoLista,
            this.SSDListas,
            this.RGBListas});
            this.dataGridView1.Location = new System.Drawing.Point(181, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(458, 250);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MemoriaRamListas
            // 
            this.MemoriaRamListas.HeaderText = "Memoria Ram";
            this.MemoriaRamListas.Name = "MemoriaRamListas";
            this.MemoriaRamListas.ReadOnly = true;
            // 
            // TarjetaVideoLista
            // 
            this.TarjetaVideoLista.HeaderText = "Tarjeta De Video";
            this.TarjetaVideoLista.Name = "TarjetaVideoLista";
            this.TarjetaVideoLista.ReadOnly = true;
            // 
            // SSDListas
            // 
            this.SSDListas.HeaderText = "SSD";
            this.SSDListas.Name = "SSDListas";
            this.SSDListas.ReadOnly = true;
            // 
            // RGBListas
            // 
            this.RGBListas.HeaderText = "Luces gaming";
            this.RGBListas.Name = "RGBListas";
            this.RGBListas.ReadOnly = true;
            // 
            // FormularioListas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEliminarFrenteLista);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_InsertarFinal);
            this.Controls.Add(this.InsertarMedioList);
            this.Controls.Add(this.txtBuscarList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRGBList);
            this.Controls.Add(this.txtSSDList);
            this.Controls.Add(this.txtTarjetaVideoList);
            this.Controls.Add(this.memoriaRamList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_descendente_lista);
            this.Controls.Add(this.btn_buscar_lista);
            this.Controls.Add(this.limpia_lista);
            this.Controls.Add(this.btn_imprimir_lista);
            this.Controls.Add(this.btn_ascendente_lista);
            this.Controls.Add(this.agregar_elemento);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormularioListas";
            this.Text = "FormularioListas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button agregar_elemento;
        private System.Windows.Forms.Button btn_ascendente_lista;
        private System.Windows.Forms.Button btn_imprimir_lista;
        private System.Windows.Forms.Button limpia_lista;
        private System.Windows.Forms.Button btn_buscar_lista;
        private System.Windows.Forms.Button btn_descendente_lista;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtRGBList;
        public System.Windows.Forms.TextBox txtSSDList;
        public System.Windows.Forms.TextBox txtTarjetaVideoList;
        public System.Windows.Forms.TextBox memoriaRamList;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtBuscarList;
        private System.Windows.Forms.Button InsertarMedioList;
        private System.Windows.Forms.Button btn_InsertarFinal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEliminarFrenteLista;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemoriaRamListas;
        private System.Windows.Forms.DataGridViewTextBoxColumn TarjetaVideoLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn SSDListas;
        private System.Windows.Forms.DataGridViewTextBoxColumn RGBListas;
    }
}