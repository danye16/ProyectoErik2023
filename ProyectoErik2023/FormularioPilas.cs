using ProyectoErik2023.Datos.Pilas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoErik2023
{
    public partial class FormularioPilas : Form
    {
        private pila Pila;

        public FormularioPilas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSSD_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string tarjetaVideo = txtTarjetaVideo.Text;
            string memoriaRam = txtmemoriaRam.Text;
            string ssd = txtSSD.Text;
            string rgb = txtRGB.Text;


            if (string.IsNullOrEmpty(tarjetaVideo) || string.IsNullOrEmpty(memoriaRam) || string.IsNullOrEmpty(ssd) || string.IsNullOrEmpty(rgb))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
            }
            else
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dataGridView1, tarjetaVideo, memoriaRam, ssd, rgb);
                dataGridView1.Rows.Add(fila);

                LimpiarCampos();
            }
        }
        public void LimpiarCampos()
        {
            txtTarjetaVideo.Clear();
            txtmemoriaRam.Clear();
            txtSSD.Clear();
            txtRGB.Clear();
        }
    }
}
