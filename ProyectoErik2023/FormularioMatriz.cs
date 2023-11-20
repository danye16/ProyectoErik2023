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
        public int indiceActual = 0; // Variable para controlar el índice actual del arreglo
        
        public FormularioMatriz()
        {
            InitializeComponent();
            computadora = new Computadora[100];
        }
        public Computadora[] computadora;
        public void AgregarPc(Computadora[] matriz)
        {
            if (indiceActual < matriz.Length) // Verifica si aún hay espacio en el arreglo
            {
                Computadora compu = new Computadora();
                compu.memoriaRam = memoriaRam.Text;
                compu.SSD = txtSSD.Text;
                compu.tarjetaVideo = txtTarjetaVideo.Text;
                compu.rgb = txtRGB.Text;

                matriz[indiceActual] = compu;
                indiceActual++; // Incrementa el índice para la próxima entrada
            }
            else
            {
                MessageBox.Show("El arreglo está lleno. No se pueden agregar más elementos.");
            }
        }
        public  void agregar_elementoM_Click(object sender, EventArgs e)
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
            for (int i = 0; i < matriz.Length; i++)
            {
                if (matriz[i] != null)
                {
                    MessageBox.Show($"Pc {i}\n" +
                                    $"Su tarjeta de video es: {matriz[i].tarjetaVideo}\n" +
                                    $"La memoria ram es: {matriz[i].memoriaRam}\n" +
                                    $"El SSD es: {matriz[i].SSD}\n" +
                                    $"El RGB es: {matriz[i].rgb}");
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

        private void limpia_listaM_Click(object sender, EventArgs e)
        {

            limpiar();

        }
        public void limpiar()
        {
            for (int i = 0; i < computadora.Length; i++)
            {
                computadora[i] = new Computadora(); 
            }
        }



    }
}
