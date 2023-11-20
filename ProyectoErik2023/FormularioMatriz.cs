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
        public FormularioMatriz()
        {
            InitializeComponent();
            computadora = new Computadora[2];
        }
        public Computadora[] computadora;
        public void AgregarPc(Computadora[] matriz)
        {
            for (int i = 0; i < 2; i++)
            {
                Computadora compu = new Computadora();
                compu.memoriaRam = memoriaRam.Text;
                compu.SSD = txtSSD.Text;
                compu.tarjetaVideo = txtTarjetaVideo.Text;
                compu.rgb = txtRGB.Text;
                matriz[i] = compu;
            }
        }
            public void agregar_elementoM_Click(object sender, EventArgs e)
        {
            AgregarPc(computadora);
          
          //Computadora  computadoras = new Computadora
          //  {
          //      memoriaRam = memoriaRam.Text,
          //  SSD = txtSSD.Text,
          //  tarjetaVideo = txtTarjetaVideo.Text,
          //  rgb = txtRGB.Text
          //  };


            //for (int i= 0; i< computadoras.Length;i++ )
            //    {
            //    //string entradaComputadora = memoriaRam.Text;
            //    //string entradaComputadora = memoriaRam.Text;
            //    //string entradaComputadora = memoriaRam.Text;
            //    //string entradaComputadora = memoriaRam.Text;

            //    //computadoras[i] = new Computadora { memoriaRam = entradaComputadora };
            //    //computadoras[i] = new Computadora { tarjetaVideo = entradaComputadora };
            //    //computadoras[i] = new Computadora { SSD = entradaComputadora };
            //    //computadoras[i] = new Computadora { rgb = entradaComputadora };

            //}

        }

   

        private void btn_imprimir_listaM_Click(object sender, EventArgs e)
        {
            
            ImprimirPc(computadora);
        }
        public void ImprimirPc(Computadora[] matriz)
        {
            for(int i = 0;i < 2;i++)
            { 
            MessageBox.Show($"Pc {i}\n"+
                $"Su tarjeta de video es: {matriz[i].tarjetaVideo}\n" +
               $"La memoria ram es: {matriz[i].memoriaRam}\n" +
               $"El SSD es: {matriz[i].SSD}\n" +
               $"El RGB es: {matriz[i].rgb}");
            }
        }

        public void MetodoBurbuja(Computadora[] matriz)
        {
            string aux;
            for (int i = 0; i < 2 - 1; i++)
            {
                for (int j = 0; j < 2 - 1; j++)
                {
                    if (string.Compare(matriz[j].tarjetaVideo, matriz[j + 1].tarjetaVideo)>0)
                    {
                        aux = matriz[j].tarjetaVideo;
                        matriz[j].tarjetaVideo = matriz[j+1].tarjetaVideo;
                        matriz[j+1].tarjetaVideo = aux;
                    }
                }
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTarjetaVideo_TextChanged(object sender, EventArgs e)
        {

        }
        private void memoriaRam_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_ascendente_listaM_Click(object sender, EventArgs e)
        {
            MetodoBurbuja(computadora);
        }
    }
}
