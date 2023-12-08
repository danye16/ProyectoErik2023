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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioListas));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRGBList = new System.Windows.Forms.TextBox();
            this.txtTarjetaVideoList = new System.Windows.Forms.TextBox();
            this.memoriaRamList = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarList = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.boxSsdL = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gridLista = new System.Windows.Forms.DataGridView();
            this.memoriaRamMatriz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PcMatriz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TarjetaVideoMatriz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SSDMatriz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RGBMatriz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btncerrar = new System.Windows.Forms.Button();
            this.btnEliminarFrenteLista = new System.Windows.Forms.Button();
            this.btn_InsertarFinal = new System.Windows.Forms.Button();
            this.InsertarMedioList = new System.Windows.Forms.Button();
            this.btn_descendente_lista = new System.Windows.Forms.Button();
            this.btn_buscar_lista = new System.Windows.Forms.Button();
            this.limpia_lista = new System.Windows.Forms.Button();
            this.btn_ascendente_lista = new System.Windows.Forms.Button();
            this.agregar_elemento = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(541, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "SSD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkRed;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(377, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Tarjeta de video";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
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
            this.txtBuscarList.Location = new System.Drawing.Point(27, 487);
            this.txtBuscarList.Name = "txtBuscarList";
            this.txtBuscarList.Size = new System.Drawing.Size(136, 20);
            this.txtBuscarList.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkRed;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(12, 523);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Introduce el modelo de tarjeta de video";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // boxSsdL
            // 
            this.boxSsdL.FormattingEnabled = true;
            this.boxSsdL.Items.AddRange(new object[] {
            "Toshiba 1Tb",
            "Kingston 512Mb",
            "Samsung 2Tb"});
            this.boxSsdL.Location = new System.Drawing.Point(503, 60);
            this.boxSsdL.Name = "boxSsdL";
            this.boxSsdL.Size = new System.Drawing.Size(136, 21);
            this.boxSsdL.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkRed;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(683, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Luces RGB";
            // 
            // gridLista
            // 
            this.gridLista.AllowUserToAddRows = false;
            this.gridLista.AllowUserToDeleteRows = false;
            this.gridLista.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.gridLista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memoriaRamMatriz,
            this.PcMatriz,
            this.TarjetaVideoMatriz,
            this.SSDMatriz,
            this.RGBMatriz});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridLista.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridLista.EnableHeadersVisualStyles = false;
            this.gridLista.GridColor = System.Drawing.Color.SkyBlue;
            this.gridLista.Location = new System.Drawing.Point(261, 386);
            this.gridLista.Name = "gridLista";
            this.gridLista.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridLista.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridLista.RowHeadersWidth = 51;
            this.gridLista.Size = new System.Drawing.Size(545, 150);
            this.gridLista.TabIndex = 38;
            // 
            // memoriaRamMatriz
            // 
            this.memoriaRamMatriz.HeaderText = "PC";
            this.memoriaRamMatriz.MinimumWidth = 6;
            this.memoriaRamMatriz.Name = "memoriaRamMatriz";
            this.memoriaRamMatriz.ReadOnly = true;
            this.memoriaRamMatriz.Width = 125;
            // 
            // PcMatriz
            // 
            this.PcMatriz.HeaderText = "Tarjeta de Video";
            this.PcMatriz.MinimumWidth = 6;
            this.PcMatriz.Name = "PcMatriz";
            this.PcMatriz.ReadOnly = true;
            this.PcMatriz.Width = 125;
            // 
            // TarjetaVideoMatriz
            // 
            this.TarjetaVideoMatriz.HeaderText = "Memoria Ram";
            this.TarjetaVideoMatriz.MinimumWidth = 6;
            this.TarjetaVideoMatriz.Name = "TarjetaVideoMatriz";
            this.TarjetaVideoMatriz.ReadOnly = true;
            this.TarjetaVideoMatriz.Width = 125;
            // 
            // SSDMatriz
            // 
            this.SSDMatriz.HeaderText = "SSD";
            this.SSDMatriz.MinimumWidth = 6;
            this.SSDMatriz.Name = "SSDMatriz";
            this.SSDMatriz.ReadOnly = true;
            this.SSDMatriz.Width = 125;
            // 
            // RGBMatriz
            // 
            this.RGBMatriz.HeaderText = "Luces gaming ";
            this.RGBMatriz.MinimumWidth = 6;
            this.RGBMatriz.Name = "RGBMatriz";
            this.RGBMatriz.ReadOnly = true;
            this.RGBMatriz.Width = 125;
            // 
            // btncerrar
            // 
            this.btncerrar.BackgroundImage = global::ProyectoErik2023.Properties.Resources.close_button_clip_art_f;
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Location = new System.Drawing.Point(863, 12);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(56, 50);
            this.btncerrar.TabIndex = 39;
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnEliminarFrenteLista
            // 
            this.btnEliminarFrenteLista.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEliminarFrenteLista.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarFrenteLista.BackgroundImage")));
            this.btnEliminarFrenteLista.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarFrenteLista.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEliminarFrenteLista.Location = new System.Drawing.Point(725, 193);
            this.btnEliminarFrenteLista.Name = "btnEliminarFrenteLista";
            this.btnEliminarFrenteLista.Size = new System.Drawing.Size(163, 69);
            this.btnEliminarFrenteLista.TabIndex = 34;
            this.btnEliminarFrenteLista.Text = "Eliminar Frente";
            this.btnEliminarFrenteLista.UseVisualStyleBackColor = false;
            this.btnEliminarFrenteLista.Click += new System.EventHandler(this.btnEliminarFrenteLista_Click);
            // 
            // btn_InsertarFinal
            // 
            this.btn_InsertarFinal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_InsertarFinal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_InsertarFinal.BackgroundImage")));
            this.btn_InsertarFinal.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InsertarFinal.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_InsertarFinal.Location = new System.Drawing.Point(12, 103);
            this.btn_InsertarFinal.Name = "btn_InsertarFinal";
            this.btn_InsertarFinal.Size = new System.Drawing.Size(163, 69);
            this.btn_InsertarFinal.TabIndex = 32;
            this.btn_InsertarFinal.Text = "Insertar al final";
            this.btn_InsertarFinal.UseVisualStyleBackColor = false;
            this.btn_InsertarFinal.Click += new System.EventHandler(this.btn_InsertarFinal_Click);
            // 
            // InsertarMedioList
            // 
            this.InsertarMedioList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InsertarMedioList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InsertarMedioList.BackgroundImage")));
            this.InsertarMedioList.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertarMedioList.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.InsertarMedioList.Location = new System.Drawing.Point(12, 193);
            this.InsertarMedioList.Name = "InsertarMedioList";
            this.InsertarMedioList.Size = new System.Drawing.Size(163, 69);
            this.InsertarMedioList.TabIndex = 31;
            this.InsertarMedioList.Text = "Insertar Medio";
            this.InsertarMedioList.UseVisualStyleBackColor = false;
            this.InsertarMedioList.Click += new System.EventHandler(this.InsertarMedioList_Click);
            // 
            // btn_descendente_lista
            // 
            this.btn_descendente_lista.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_descendente_lista.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_descendente_lista.BackgroundImage")));
            this.btn_descendente_lista.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_descendente_lista.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_descendente_lista.Location = new System.Drawing.Point(725, 290);
            this.btn_descendente_lista.Name = "btn_descendente_lista";
            this.btn_descendente_lista.Size = new System.Drawing.Size(163, 69);
            this.btn_descendente_lista.TabIndex = 5;
            this.btn_descendente_lista.Text = "Ordenar Descendente";
            this.btn_descendente_lista.UseVisualStyleBackColor = false;
            this.btn_descendente_lista.Click += new System.EventHandler(this.btn_descendente_lista_Click);
            // 
            // btn_buscar_lista
            // 
            this.btn_buscar_lista.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_buscar_lista.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar_lista.BackgroundImage")));
            this.btn_buscar_lista.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar_lista.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_buscar_lista.Location = new System.Drawing.Point(12, 399);
            this.btn_buscar_lista.Name = "btn_buscar_lista";
            this.btn_buscar_lista.Size = new System.Drawing.Size(163, 69);
            this.btn_buscar_lista.TabIndex = 4;
            this.btn_buscar_lista.Text = "Buscar Elemento";
            this.btn_buscar_lista.UseVisualStyleBackColor = false;
            this.btn_buscar_lista.Click += new System.EventHandler(this.btn_buscar_lista_Click);
            // 
            // limpia_lista
            // 
            this.limpia_lista.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.limpia_lista.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("limpia_lista.BackgroundImage")));
            this.limpia_lista.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpia_lista.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.limpia_lista.Location = new System.Drawing.Point(12, 290);
            this.limpia_lista.Name = "limpia_lista";
            this.limpia_lista.Size = new System.Drawing.Size(163, 69);
            this.limpia_lista.TabIndex = 3;
            this.limpia_lista.Text = "Limpiar Lista";
            this.limpia_lista.UseVisualStyleBackColor = false;
            this.limpia_lista.Click += new System.EventHandler(this.limpia_lista_Click);
            // 
            // btn_ascendente_lista
            // 
            this.btn_ascendente_lista.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ascendente_lista.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ascendente_lista.BackgroundImage")));
            this.btn_ascendente_lista.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ascendente_lista.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_ascendente_lista.Location = new System.Drawing.Point(725, 103);
            this.btn_ascendente_lista.Name = "btn_ascendente_lista";
            this.btn_ascendente_lista.Size = new System.Drawing.Size(163, 69);
            this.btn_ascendente_lista.TabIndex = 1;
            this.btn_ascendente_lista.Text = "Ordenar Ascendente";
            this.btn_ascendente_lista.UseVisualStyleBackColor = false;
            this.btn_ascendente_lista.Click += new System.EventHandler(this.btn_ascendente_lista_Click);
            // 
            // agregar_elemento
            // 
            this.agregar_elemento.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.agregar_elemento.BackgroundImage = global::ProyectoErik2023.Properties.Resources._20cc4e08ae5a8f5d7448a4087aaacdb7;
            this.agregar_elemento.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar_elemento.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.agregar_elemento.Location = new System.Drawing.Point(12, 12);
            this.agregar_elemento.Name = "agregar_elemento";
            this.agregar_elemento.Size = new System.Drawing.Size(163, 69);
            this.agregar_elemento.TabIndex = 0;
            this.agregar_elemento.Text = "Agregar Elemento";
            this.agregar_elemento.UseVisualStyleBackColor = false;
            this.agregar_elemento.Click += new System.EventHandler(this.agregar_elemento_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoErik2023.Properties.Resources.listaimagen;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(933, 559);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // FormularioListas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 559);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.gridLista);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.boxSsdL);
            this.Controls.Add(this.btnEliminarFrenteLista);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_InsertarFinal);
            this.Controls.Add(this.InsertarMedioList);
            this.Controls.Add(this.txtBuscarList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRGBList);
            this.Controls.Add(this.txtTarjetaVideoList);
            this.Controls.Add(this.memoriaRamList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_descendente_lista);
            this.Controls.Add(this.btn_buscar_lista);
            this.Controls.Add(this.limpia_lista);
            this.Controls.Add(this.btn_ascendente_lista);
            this.Controls.Add(this.agregar_elemento);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormularioListas";
            this.Text = "FormularioListas";
            ((System.ComponentModel.ISupportInitialize)(this.gridLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button agregar_elemento;
        private System.Windows.Forms.Button btn_ascendente_lista;
        private System.Windows.Forms.Button limpia_lista;
        private System.Windows.Forms.Button btn_buscar_lista;
        private System.Windows.Forms.Button btn_descendente_lista;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtRGBList;
        public System.Windows.Forms.TextBox txtTarjetaVideoList;
        public System.Windows.Forms.TextBox memoriaRamList;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtBuscarList;
        private System.Windows.Forms.Button InsertarMedioList;
        private System.Windows.Forms.Button btn_InsertarFinal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEliminarFrenteLista;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox boxSsdL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gridLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoriaRamMatriz;
        private System.Windows.Forms.DataGridViewTextBoxColumn PcMatriz;
        private System.Windows.Forms.DataGridViewTextBoxColumn TarjetaVideoMatriz;
        private System.Windows.Forms.DataGridViewTextBoxColumn SSDMatriz;
        private System.Windows.Forms.DataGridViewTextBoxColumn RGBMatriz;
        private System.Windows.Forms.Button btncerrar;
    }
}