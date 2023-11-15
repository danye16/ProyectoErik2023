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
    public partial class Form1 : Form
    {
        FormularioListas formularioListas;
        FormularioColascs formularioColascs;
        FormularioMatriz formularioMatriz;
        FormularioPilas formularioPilas;
        public Form1()
        {
            InitializeComponent();
            formularioListas= new FormularioListas();
            formularioColascs = new FormularioColascs();
            formularioMatriz = new FormularioMatriz();
            formularioPilas = new FormularioPilas();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formularioMatriz.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            formularioListas.ShowDialog();
            
        }

        private void btnPilas_Click(object sender, EventArgs e)
        {
            formularioPilas.ShowDialog();
        }

        private void btnColas_Click(object sender, EventArgs e)
        {
            formularioColascs.ShowDialog();
        }
    }
}
