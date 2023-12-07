using ProyectoErik2023.Datos.Cola;
using ProyectoErik2023.Datos.Pila;
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
    public partial class FormularioColascs : Form
    {
        ColaAlcuadrado colaAlcuadrado1 = new ColaAlcuadrado(capacidad: 100);


        public FormularioColascs()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ActualizarDataGridView()
        {
            dataGridView1.Rows.Clear(); // Limpia el DataGridView antes de actualizarlo

            int indice = colaAlcuadrado1.frente; // Utiliza el frente de la cola como índice inicial

            for (int i = 0; i < colaAlcuadrado1.LongitudCola(); i++)
            {
                dataGridView1.Rows.Add(
                    colaAlcuadrado1.computadoraCola[indice].tarjetaVideo,
                    colaAlcuadrado1.computadoraCola[indice].memoriaRam,
                    colaAlcuadrado1.computadoraCola[indice].SSD,
                    colaAlcuadrado1.computadoraCola[indice].rgb
                );

                indice = (indice + 1) % colaAlcuadrado1.capacidadCola; // Avanza al siguiente elemento de la cola circular
            }
            //dataGridView1.Rows.Clear();

            //if (!colaAlcuadrado1.ColaVacia())
            //{
            //    int indice = colaAlcuadrado1.Frente;

            //    do
            //    {
            //        dataGridView1.Rows.Add(
            //            colaAlcuadrado1.computadoraCola[indice].tarjetaVideo,
            //            colaAlcuadrado1.computadoraCola[indice].memoriaRam,
            //            colaAlcuadrado1.computadoraCola[indice].SSD,
            //            colaAlcuadrado1.computadoraCola[indice].rgb
            //        );

            //        indice = (indice + 1) % colaAlcuadrado1.capacidadCola;

            //    } while (indice != (colaAlcuadrado1.Final + 1) % colaAlcuadrado1.capacidadCola);
            //}
            //else
            //{
            //    MessageBox.Show("La cola está vacía.");
            //}
        }

        private void btnAgregarCola_Click(object sender, EventArgs e)
        {

            //ME EQUIVOQUE Y LE PUSE BTN EN VEZ DE TXT
            if (btnTarjetaCola.Text == string.Empty || txtMemoriaRamCola.Text == string.Empty || txtSSDCola.Text == string.Empty || txtRGB.Text == string.Empty)
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }
            else
            {
                Computadora nuevaComputadora = new Computadora()
                {
                    memoriaRam = txtMemoriaRamCola.Text,
                    tarjetaVideo = btnTarjetaCola.Text,
                    SSD = txtSSDCola.Text,
                    rgb = txtRGB.Text
                };
                colaAlcuadrado1.AgregarElemento(nuevaComputadora);

                ActualizarDataGridView();

                txtMemoriaRamCola.Text = string.Empty;
                btnTarjetaCola.Text = string.Empty;
                txtSSDCola.Text = string.Empty;
                txtRGB.Text = string.Empty;
                //LONGITUD DE CUANTOS ELEMENTOS EXISTEN EN EL ARREGLO

                //colaAlcuadrado1.Encolar(nuevaComputadora);


                //ActualizarDataGridView();
            }
        }

        private void btn_descendente_cola_Click(object sender, EventArgs e)
        {
            colaAlcuadrado1.OrdenarDescendente();


            ActualizarDataGridView();
        }

        private void btnBuscarCola_Click(object sender, EventArgs e)
        {
            string palabra = txtBuscarCola.Text;
            colaAlcuadrado1.BuscarEnCola(palabra);
        }

        private void limpia_cola_Click(object sender, EventArgs e)
        {
            colaAlcuadrado1.LimpiarCola();
            ActualizarDataGridView();
        }

        private void FormularioColascs_Load(object sender, EventArgs e)
        {

        }

        private void btn_imprimir_cola_Click(object sender, EventArgs e)
        {
            colaAlcuadrado1.SacarElemento();
            ActualizarDataGridView();
        }

        private void btn_ascendente_cola_Click(object sender, EventArgs e)
        {
            colaAlcuadrado1.OrdenarAscendente();
            ActualizarDataGridView();
        }
    }
}
