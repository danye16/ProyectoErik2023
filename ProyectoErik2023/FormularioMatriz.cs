using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoErik2023
{
    public partial class FormularioMatriz : Form
    {
        Computadora[] computadoras;
        public FormularioMatriz()
        {
            InitializeComponent();
        }

        private void agregar_elementoM_Click(object sender, EventArgs e)
        {
            computadoras = new Computadora[5];


            for (int i= 0; i< computadoras.Length;i++ )
                {
                MessageBox.Show("Ingrese la tarjeta de video");
                string entradaComputadora = memoriaRam.Text;
                computadoras[i] = new Computadora { tarjetaVideo = entradaComputadora };
            }

        }

        private void prueba1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_imprimir_listaM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su tarjeta de video es: " + computadoras[1].tarjetaVideo);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTarjetaVideo_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
