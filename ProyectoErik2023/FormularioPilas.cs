using ProyectoErik2023.Datos.Listas;
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
    public partial class FormularioPilas : Form
    {
        PilaAlcuadrado PilaAlcuadrado1 = new PilaAlcuadrado();
        public FormularioPilas()
        {
            InitializeComponent();
        }

        private void agregar_elementoP_Click(object sender, EventArgs e)
        {

            if (txtTarjetaVideo.Text == string.Empty || txtMemoriaRam.Text == string.Empty || boxSsdP.Text == string.Empty || txtRGB.Text == string.Empty)
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }
            else
            {
                Computadora computadora = new Computadora
                {
                    memoriaRam = txtMemoriaRam.Text,
                    tarjetaVideo = txtTarjetaVideo.Text,
                    SSD = boxSsdP.Text,
                    rgb = txtRGB.Text
                };
                PilaAlcuadrado1.InsertarElemento(computadora);

                // Obtener los elementos y actualizar el DataGridView
                ActualizarDataGridView();
            }

            string aa = "";
            txtMemoriaRam.Text = aa;
            txtTarjetaVideo.Text = string.Empty;
            boxSsdP.Text = string.Empty;
            txtRGB.Text = string.Empty;


            //    if (txtTarjetaVideo.Text == string.Empty || txtMemoriaRam.Text == string.Empty || txtSSD.Text == string.Empty || txtRGB.Text == string.Empty)
            //    {
            //        MessageBox.Show("Todos los campos son obligatorios");
            //    }
            //    else
            //    {
            //        Computadora computadora = new Computadora
            //        {
            //            memoriaRam = txtMemoriaRam.Text,
            //            tarjetaVideo = txtTarjetaVideo.Text,
            //            SSD = txtSSD.Text,
            //            rgb = txtRGB.Text

            //        };
            //        PilaAlcuadrado1.InsertarElemento(computadora);

            //    }
            //    string aa = "";
            //    txtMemoriaRam.Text = aa;
            //    txtTarjetaVideo.Text = string.Empty;
            //    txtSSD.Text = string.Empty;
            //    txtRGB.Text = string.Empty;



        }

        private void ActualizarDataGridView()
        {
            dataGridView1.Rows.Clear();

            Computadora[] elementos = PilaAlcuadrado1.computadoraPila;

            for (int i = PilaAlcuadrado1.CantidadElemento() - 1; i >= 0; i--)
            {
                Computadora computadora = elementos[i];
                dataGridView1.Rows.Add(computadora.memoriaRam, computadora.tarjetaVideo, computadora.SSD, computadora.rgb);
            }
        }

        private void txtTarjetaVideo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMemoriaRam_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_imprimir_pila_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string palabra = txtBuscar.Text;
            PilaAlcuadrado1.Buscar(palabra);
        }

        private void txtEliminarCima_Click(object sender, EventArgs e)
        {
            PilaAlcuadrado1.ExtraerElemento();
            ActualizarDataGridView();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PilaAlcuadrado1.Limpiar();
            ActualizarDataGridView();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            ActualizarDataGridView();

        }
        private void MostrarDatosEnFormulario(Computadora computadora)
        {
            txtMemoriaRam.Text = computadora.memoriaRam;
            txtTarjetaVideo.Text = computadora.tarjetaVideo;
            boxSsdP.Text = computadora.SSD;
            txtRGB.Text = computadora.rgb;
        }

       

        private void btnEnviarCambiosCola_Click(object sender, EventArgs e)
        {
            Computadora computadoraModificada = new Computadora
            {
                memoriaRam = txtMemoriaRam.Text,
                tarjetaVideo = txtTarjetaVideo.Text,
                SSD = boxSsdP.Text,
                rgb = txtRGB.Text
            };

            if (PilaAlcuadrado1.ActualizarComputadora(computadoraModificada))
            {
                MessageBox.Show("Cambios aplicados correctamente.");
                ActualizarDataGridView(); 
            }
            else
            {
                MessageBox.Show("Error al actualizar la computadora en la pila.");
            }
            ActualizarDataGridView();
            string aa = "";
            txtMemoriaRam.Text = aa;
            txtTarjetaVideo.Text = string.Empty;
            boxSsdP.Text = string.Empty;
            txtRGB.Text = string.Empty;
        }

        private void btnBuscarTarjeta_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscarTarjetaEditar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
