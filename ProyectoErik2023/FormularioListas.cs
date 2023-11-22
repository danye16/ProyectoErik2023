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
        Lista lista;


        public FormularioListas()
        {
            InitializeComponent();
            lista = new Lista(this);
        }





        private void btn_ascendente_lista_Click(object sender, EventArgs e)
        {

        }

        private void btn_imprimir_lista_Click(object sender, EventArgs e)
        {

            lista.ImprimirLista();
        }

        private void agregar_elemento_Click(object sender, EventArgs e)
        {
            Computadora compu = new Computadora()
            {
                memoriaRam = memoriaRamList.Text,
                tarjetaVideo = txtTarjetaVideoList.Text,
                SSD = txtSSDList.Text,
                rgb = txtRGBList.Text
            };
            lista.AgregarLista();
            MessageBox.Show(compu.tarjetaVideo);
        }
        private void limpia_lista_Click(object sender, EventArgs e)
        {

        }
    }

    
    //Computadora computadora= new Computadora(memoriaRamList.Text,txtTarjetaVideoList.Text,txtSSDList.Text,txtRGBList.Text);
    //lista.AgregarLista(computadora);
}