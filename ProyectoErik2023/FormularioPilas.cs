using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoErik2023.Datos.Listas;
using ProyectoErik2023.Datos.Pila;
namespace ProyectoErik2023
{
    
    public partial class FormularioPilas : Form
    {

        PilaAlcuadrado pilaAlcuadrado = new PilaAlcuadrado();
        public FormularioPilas()
        {
            InitializeComponent();
        }

        private void agregar_elementoP_Click(object sender, EventArgs e)
        {
            if (txtVideoPila.Text == string.Empty || txtRamPila.Text == string.Empty || txtSsdPila.Text == string.Empty || txtRgbPila.Text == string.Empty)
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }
            else
            {
                Computadora computadora = new Computadora
                {
                    memoriaRam = txtRamPila.Text,
                    tarjetaVideo = txtVideoPila.Text,
                    SSD = txtSsdPila.Text,
                    rgb = txtRgbPila.Text

                };
                pilaAlcuadrado.InsertarElemento(computadora);
            }
            string aa = "";
            txtRamPila.Text = aa;
            txtVideoPila.Text = string.Empty;
            txtSsdPila.Text = string.Empty;
            txtRgbPila.Text = string.Empty;
            //   pilaAlcuadrado.InsertarElemento(computadora);
        }

        private void btn_buscar_elementoP_Click(object sender, EventArgs e)
        {
            string palabra = txtBuscarPila.Text;

            pilaAlcuadrado.Buscar(palabra);
        }
    }
}
