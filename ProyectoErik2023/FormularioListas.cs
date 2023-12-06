using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoErik2023.Listas.Nose;
using ProyectoErik2023.Datos.Listas;

namespace ProyectoErik2023
{
    public partial class FormularioListas : Form
    {
        Lista lista=new Lista();


         public DataGridView dataGridViewLista;


        public FormularioListas()
        {
            InitializeComponent();
            
            
        }


        private void btn_ascendente_lista_Click(object sender, EventArgs e)
        {
           lista.OrdenarAscendenteLista();
        }

        private void btn_imprimir_lista_Click(object sender, EventArgs e)
        {

            lista.ImprimirLista();
        }

        private void agregar_elemento_Click(object sender, EventArgs e)
        {
            if (txtTarjetaVideoList.Text == string.Empty || memoriaRamList.Text == string.Empty || txtSSDList.Text == string.Empty || txtRGBList.Text == string.Empty)
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }
            else
            {
                Computadora computadora = new Computadora
                {
                    memoriaRam = memoriaRamList.Text,
                    tarjetaVideo = txtTarjetaVideoList.Text,
                    SSD = txtSSDList.Text,
                    rgb = txtRGBList.Text

                };
                lista.AgregarLista(computadora);
                ActualizarDataGridView(lista);
            }
            string aa = "";
            memoriaRamList.Text = aa;
            txtTarjetaVideoList.Text = string.Empty;
            txtSSDList.Text = string.Empty;
            txtRGBList.Text = string.Empty;

        }

        private void btn_buscar_lista_Click(object sender, EventArgs e)
        {
            string palabra = txtBuscarList.Text;
            lista.BuscarElemento(palabra);
        }

        private void InsertarMedioList_Click(object sender, EventArgs e)
        {
            if (txtTarjetaVideoList.Text == string.Empty || memoriaRamList.Text == string.Empty || txtSSDList.Text == string.Empty || txtRGBList.Text == string.Empty)
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }
            else
            {
                Computadora computadora = new Computadora
                {
                    memoriaRam = memoriaRamList.Text,
                    tarjetaVideo = txtTarjetaVideoList.Text,
                    SSD = txtSSDList.Text,
                    rgb = txtRGBList.Text

                };
                //lista.InsertarMedioLista(computadora);
                lista.InsertarMedioLista(computadora);
                ActualizarDataGridView(lista);
            }
         
            string aa = "";
            memoriaRamList.Text = aa;
            txtTarjetaVideoList.Text = string.Empty;
            txtSSDList.Text = string.Empty;
            txtRGBList.Text = string.Empty;
        }

        private void btn_descendente_lista_Click(object sender, EventArgs e)
        {
            lista.OrdenarDescendenteLista();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_InsertarFinal_Click(object sender, EventArgs e)
        {
            if (txtTarjetaVideoList.Text == string.Empty || memoriaRamList.Text == string.Empty || txtSSDList.Text == string.Empty || txtRGBList.Text == string.Empty)
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }
            else
            {
                Computadora computadora = new Computadora
                {
                    memoriaRam = memoriaRamList.Text,
                    tarjetaVideo = txtTarjetaVideoList.Text,
                    SSD = txtSSDList.Text,
                    rgb = txtRGBList.Text

                };
                lista.InsertarFinalLista(computadora);
                ActualizarDataGridView(lista);

            }
           
            string aa = "";
            memoriaRamList.Text = aa;
            txtTarjetaVideoList.Text = string.Empty;
            txtSSDList.Text = string.Empty;
            txtRGBList.Text = string.Empty;
        }

        private void limpia_lista_Click(object sender, EventArgs e)
        {

            string aa = "";
            memoriaRamList.Text = aa;
            txtTarjetaVideoList.Text = string.Empty;
            txtSSDList.Text = string.Empty;
            txtRGBList.Text = string.Empty;

            lista.VaciarLista();

            MessageBox.Show("Se a limpiado todo jefe");
        }

        public void ActualizarDataGridView(Lista lista)
        {
            dataGridViewLista.Rows.Clear(); // Borra todas las filas existentes en el DataGridView

            Nodo nodoActual = lista.ObtenerPrimerNodo();

            while (nodoActual != null)
            {
                dataGridViewLista.Rows.Add(nodoActual.computadora.memoriaRam, nodoActual.computadora.tarjetaVideo, nodoActual.computadora.SSD, nodoActual.computadora.rgb);
                nodoActual = nodoActual.siguiente;
            }
        }



        private void btnEliminarFrenteLista_Click(object sender, EventArgs e)
        {
            lista.EliminarPrimeraPos();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       
            private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Computadora computadora= new Computadora(memoriaRamList.Text,txtTarjetaVideoList.Text,txtSSDList.Text,txtRGBList.Text);
        //lista.AgregarLista(computadora);

    }
}
