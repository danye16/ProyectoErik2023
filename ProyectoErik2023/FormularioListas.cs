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
        Lista lista;

        public FormularioListas()
        {
            InitializeComponent();
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
            Computadora computadora= new Computadora();
            lista.AgregarLista(computadora);
        }
    }
}
