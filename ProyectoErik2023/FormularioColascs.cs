using ProyectoErik2023.Datos.Colas;
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
        public FormularioColascs()
        {
            InitializeComponent();
            miCola = new ColasAlcuadrado();
        }
        private ColasAlcuadrado miCola;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtTarjetaCola.Text == string.Empty || txtMemoriaRamCola.Text == string.Empty || boxSsdC.Text == string.Empty || txtRGBCola.Text == string.Empty)
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }
            else
            {
                
                Computadora computadora = new Computadora
                {
                    memoriaRam = txtMemoriaRamCola.Text,
                    tarjetaVideo = txtTarjetaCola.Text,
                    SSD = boxSsdC.Text,
                    rgb = txtRGBCola.Text
                };

               
                miCola.InsertarElemento(computadora);

               
                ActualizarDataGridView();

               
                txtMemoriaRamCola.Text = string.Empty;
                txtTarjetaCola.Text = string.Empty;
                boxSsdC.Text = string.Empty;
                txtRGBCola.Text = string.Empty;
            }
        }

        private void ActualizarDataGridView()
        {
            dataGridView1.Rows.Clear(); 

            
            foreach (var computadora in miCola.computadoraCola)
            {
                if (computadora != null)
                {
                    dataGridView1.Rows.Add( 
                      computadora.tarjetaVideo,
                      computadora.memoriaRam,
                      computadora.SSD,
                      computadora.rgb);
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnLimpiarCola_Click(object sender, EventArgs e)
        {
            miCola.Limpiar();
            ActualizarDataGridView();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string tarjetaBuscada = txtBuscar.Text;

            miCola.Buscar(tarjetaBuscada);
            ActualizarDataGridView();
            
        }
        
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void MostrarDatosEnFormulario(Computadora computadora)
        {
            txtMemoriaRamCola.Text = computadora.memoriaRam;
            txtTarjetaCola.Text = computadora.tarjetaVideo;
            boxSsdC.Text = computadora.SSD;
            txtRGBCola.Text = computadora.rgb;
        }
        private void btnBuscarTarjeta_Click(object sender, EventArgs e)
        {
            string tarjetaBuscada = txtBuscarTarjetaCola.Text;

            Computadora computadoraEncontrada;
            bool encontrado = miCola.BuscarPorTarjeta(tarjetaBuscada, out computadoraEncontrada);

            if (encontrado)
            {
                MostrarDatosEnFormulario(computadoraEncontrada); // Muestra los datos en los textBox
            }
            else
            {
                MessageBox.Show("La tarjeta no se encontró en la cola.");
            }

        }

        private void btnEnviarCambiosColas_Click(object sender, EventArgs e)
        {
            Computadora computadoraModificada = new Computadora
            {
                memoriaRam = txtMemoriaRamCola.Text,
                tarjetaVideo = txtTarjetaCola.Text,
                SSD = boxSsdC.Text,
                rgb = txtRGBCola.Text
            };

            if (miCola.ActualizarComputadora(computadoraModificada))
            {
                MessageBox.Show("Cambios aplicados correctamente.");
                ActualizarDataGridView();
            }
            else
            {
                MessageBox.Show("Error al actualizar la computadora en la cola.");
            }

        }

        private void FormularioColascs_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btncerrarP_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
//aaaa