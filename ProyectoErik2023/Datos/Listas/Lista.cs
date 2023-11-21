using ProyectoErik2023.Listas.Nose;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoErik2023.Datos.Listas
{
    public class Lista : FormularioListas
    {

        private Nodo _primero;
        private Nodo _ultimo;
        public Lista()
        {
            //crear constructor
            _primero = _ultimo = null;
        }
        public bool ListaVacia()
        {
            return _primero != null ? false : true;
        }

        public int LongitudLista()
        {
            if (ListaVacia())
                return 0;
            else
                if (_primero != null && _primero.siguiente == null) return 1;
            else
            {
                int contador = 0;
                Nodo actual = _primero;
                while (actual.siguiente != null)
                {
                    actual = actual.siguiente;
                    contador++;
                }
                return contador + 1;
            }
        }
        public void ImprimirLista()
        {
            if (ListaVacia())
                MessageBox.Show("La Lista esta vacia señor humano");
            Nodo actual = _primero;
            while (actual != null)
            {
                MessageBox.Show(actual.computadora.memoriaRam + actual.computadora.tarjetaVideo
                    + actual.computadora.SSD + actual.computadora.rgb
                     );
                actual = actual.siguiente;
            }

        }
        public void BuscarElemento()
        {

            string objetivo = txtBuscarList.Text;
            bool encontrado = false;
            if (ListaVacia())
                MessageBox.Show("El modelo con esa tarjeta de video no esta disponible");

            else
            {
                Nodo actual = _primero;
                while (actual != null)
                {
                    if (actual.computadora.tarjetaVideo == objetivo)
                    {
                        encontrado = true;
                        MessageBox.Show("si se encuentra el elemento encontrado");
                        break;
                    }
                    else
                    {
                        actual = actual.siguiente;

                    }

                }
            }
            if (!encontrado)
            {
                MessageBox.Show("El modelo con esa tarjeta de video no esta disponible");
            }
        }

        public void AgregarLista (Computadora computadora)

        {
            if (ListaVacia())
            {
                _primero=new Nodo(computadora);
            }
        }
    }
}
