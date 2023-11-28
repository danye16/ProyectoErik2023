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
        public int indice = 0;
        public FormularioMatriz()
        {
            InitializeComponent();
            computadora = new Computadora[3];
        }
        public Computadora[] computadora;
        public void AgregarPc(Computadora[] matriz)
        {

            if (txtTarjetaVideo.Text == string.Empty || memoriaRam.Text == string.Empty || txtSSD.Text == string.Empty || txtRGB.Text == string.Empty)
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }
            else
            {
                if (indice < matriz.Length)
                {
                    Computadora compu = new Computadora();
                    compu.memoriaRam = memoriaRam.Text;
                    compu.SSD = txtSSD.Text;
                    compu.tarjetaVideo = txtTarjetaVideo.Text;
                    compu.rgb = txtRGB.Text;
                    matriz[indice] = compu;
                    indice++;
                    MessageBox.Show("Se guardaron los datos exitosamente");

                }
                else
                {
                    MessageBox.Show("Array lleno joven");

                }
            }


           

            string aa = "";
            memoriaRam.Text = aa;
            txtTarjetaVideo.Text = string.Empty;
            txtSSD.Text = string.Empty;
            txtRGB.Text = string.Empty;




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
            for(int i = 0;i < matriz.Length;i++)
            {
                if (matriz[i] != null)
                { 
                MessageBox.Show($"Pc {i}\n" +
                    $"Su tarjeta de video es: {matriz[i].tarjetaVideo}\n" +
                   $"La memoria ram es: {matriz[i].memoriaRam}\n" +
                   $"El SSD es: {matriz[i].SSD}\n" +
                   $"El RGB es: {matriz[i].rgb}");
                }
                //printVideo.Text=matriz[i].tarjetaVideo;
                //  printRam.Text = matriz[i].memoriaRam;
                //   printSSD.Text = matriz[i].SSD;
                //   printRGB.Text = matriz[i].rgb;




            }
        }

        public void Burbuja()
        {
            if (indice == computadora.Length)
            {
                for (int i = 0; i < computadora.Length - 1; i++)
                {
                    for (int j = 0; j < computadora.Length - 1; j++)
                    {
                        if (string.Compare(computadora[j].tarjetaVideo, computadora[j + 1].tarjetaVideo) < 0)
                        {
                            Computadora aux = computadora[j];
                            computadora[j] = computadora[j + 1];
                            computadora[j + 1] = aux;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Tienes que llenar la matriz para ordenar");
            }
           
        }
        public void BurbujaDescendente()
        {
            if (indice==computadora.Length)
            {

                for (int i = 0; i < computadora.Length - 1; i++)
                {
                    for (int j = 0; j < computadora.Length - 1; j++)
                    {

                        if (string.Compare(computadora[j].tarjetaVideo, computadora[j + 1].tarjetaVideo) == -1)
                        {
                            Computadora aux = computadora[j];
                            computadora[j] = computadora[j + 1];
                            computadora[j + 1] = aux;
                        }
                    }
                    


                }
            }
            else
            {
                MessageBox.Show("Tienes que llenar la matriz para ordenar");
            }






        }

        public void Buscar()
        {

            string palabra = textBuscar.Text;
            bool centinela = false;
            int media = 0;
            int inicio = 0;
            int final = computadora.Length;
            if (palabra == string.Empty)
            {
                MessageBox.Show("Tienes que llenar el campo");

            }
            else
            {
                while (inicio < final && centinela == false)
                {

                    media = (inicio + final) / 2;
                    if (string.Compare(palabra, computadora[media].tarjetaVideo) == 0)
                    {
                        centinela = true;
                        MessageBox.Show($"El elemento {palabra} se encuentra en la posicion {media} ");
                    }
                    if (string.Compare(palabra, computadora[media].tarjetaVideo) < 0)
                        final = media - 1;
                    else
                        inicio = media + 1;

                    if (centinela == false)
                    {
                        MessageBox.Show($"El elemento {palabra} no existe ");
                    }
                }
            }
           
               
        }
        public void AgregarPcFinal(Computadora[] matriz)
        {
            if (txtTarjetaVideo.Text == string.Empty || memoriaRam.Text == string.Empty || txtSSD.Text == string.Empty || txtRGB.Text == string.Empty)
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }
            else
            {
                int final = computadora.Length - 1;

                Computadora compu = new Computadora();
                compu.memoriaRam = memoriaRam.Text;
                compu.SSD = txtSSD.Text;
                compu.tarjetaVideo = txtTarjetaVideo.Text;
                compu.rgb = txtRGB.Text;
                matriz[final] = compu;
                indice++;
                MessageBox.Show("Se guardaron los datos exitosamente");

            }

            string aa = "";
            memoriaRam.Text = aa;
            txtTarjetaVideo.Text = string.Empty;
            txtSSD.Text = string.Empty;
            txtRGB.Text = string.Empty;


        }
        public void Limpiar()
        {
            Computadora compu = new Computadora();
           memoriaRam.Clear();
            txtSSD.Clear(); 
             txtTarjetaVideo.Clear();
             txtRGB.Clear();
            indice = 0;

            for (int i=0; i<computadora.Length; i++)
            {
                computadora[i] = null;
            }

            
                MessageBox.Show("Se a limpiado todo jefe");
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
            Burbuja();
            ImprimirPc(computadora);

        }

        private void btn_descendente_listaM_Click(object sender, EventArgs e)
        {
            BurbujaDescendente();
        }

        private void btn_buscar_listaM_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btnInsertarfinal_Click(object sender, EventArgs e)
        {
            AgregarPcFinal(computadora);
        }

        private void limpia_listaM_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void FormularioMatriz_Load(object sender, EventArgs e)
        {
            
        }
    }
}
