﻿using System;
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
        
       
        public FormularioListas()
        {
            InitializeComponent();
        }

        private void btn_ascendente_lista_Click(object sender, EventArgs e)
        {
           lista.OrdenarAscendenteLista();
            ActualizarDataGridView();

        }

        private void btn_imprimir_lista_Click(object sender, EventArgs e)
        {

            lista.ImprimirLista();
        }

        private void agregar_elemento_Click(object sender, EventArgs e)
        {
            if (txtTarjetaVideoList.Text == string.Empty || memoriaRamList.Text == string.Empty || boxSsdL.Text == string.Empty || txtRGBList.Text == string.Empty)
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }
            else
            {
                Computadora computadora = new Computadora
                {
                    memoriaRam = memoriaRamList.Text,
                    tarjetaVideo = txtTarjetaVideoList.Text,
                    SSD = boxSsdL.Text,
                    rgb = txtRGBList.Text

                };
                lista.AgregarLista(computadora);
                ActualizarDataGridView();

            }
            string aa = "";
            memoriaRamList.Text = aa;
            txtTarjetaVideoList.Text = string.Empty;
            boxSsdL.Text = string.Empty;
            txtRGBList.Text = string.Empty;

        }

        private void btn_buscar_lista_Click(object sender, EventArgs e)
        {
            string palabra = txtBuscarList.Text;
            lista.BuscarElemento(palabra);
        }

        private void InsertarMedioList_Click(object sender, EventArgs e)
        {
            if (txtTarjetaVideoList.Text == string.Empty || memoriaRamList.Text == string.Empty || boxSsdL.Text == string.Empty || txtRGBList.Text == string.Empty)
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }
            else
            {
                Computadora computadora = new Computadora
                {
                    memoriaRam = memoriaRamList.Text,
                    tarjetaVideo = txtTarjetaVideoList.Text,
                    SSD = boxSsdL.Text,
                    rgb = txtRGBList.Text

                };
                //lista.InsertarMedioLista(computadora);
                lista.InsertarMedioLista(computadora);
                ActualizarDataGridView();

            }

            string aa = "";
            memoriaRamList.Text = aa;
            txtTarjetaVideoList.Text = string.Empty;
            boxSsdL.Text = string.Empty;
            txtRGBList.Text = string.Empty;
        }

        private void btn_descendente_lista_Click(object sender, EventArgs e)
        {
            lista.OrdenarDescendenteLista();
            ActualizarDataGridView();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_InsertarFinal_Click(object sender, EventArgs e)
        {
            if (txtTarjetaVideoList.Text == string.Empty || memoriaRamList.Text == string.Empty || boxSsdL.Text == string.Empty || txtRGBList.Text == string.Empty)
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }
            else
            {
                Computadora computadora = new Computadora
                {
                    memoriaRam = memoriaRamList.Text,
                    tarjetaVideo = txtTarjetaVideoList.Text,
                    SSD = boxSsdL.Text,
                    rgb = txtRGBList.Text

                };
                lista.InsertarFinalLista(computadora);
                ActualizarDataGridView();

            }

            string aa = "";
            memoriaRamList.Text = aa;
            txtTarjetaVideoList.Text = string.Empty;
            boxSsdL.Text = string.Empty;
            txtRGBList.Text = string.Empty;
        }

        private void limpia_lista_Click(object sender, EventArgs e)
        {

            string aa = "";
            memoriaRamList.Text = aa;
            txtTarjetaVideoList.Text = string.Empty;
            boxSsdL.Text = string.Empty;
            txtRGBList.Text = string.Empty;

            lista.VaciarLista();
            ActualizarDataGridView();


            MessageBox.Show("Se a limpiado todo jefe");
        }

        private void btnEliminarFrenteLista_Click(object sender, EventArgs e)
        {
            lista.EliminarPrimeraPos();
            ActualizarDataGridView();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void ActualizarDataGridView()
        {
            gridLista.Rows.Clear();

            Nodo actual = lista._primero;
            int indice = 0;

            while (actual != null)
            while (actual != null)
            {
                gridLista.Rows.Add(
                    $"Pc {indice}",
                    actual.computadora.tarjetaVideo,
                    actual.computadora.memoriaRam,
                    actual.computadora.SSD,
                    actual.computadora.rgb
                );

                actual = actual.siguiente;
                indice++;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
