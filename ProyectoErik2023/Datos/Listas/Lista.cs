using ProyectoErik2023.Listas.Nose;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoErik2023.Datos.Listas
{
    public class Lista 
    {
        FormularioListas formularioListas;

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
            //MessageBox.Show(_primero.computadora.SSD);

            while (actual != null)
            {
                MessageBox.Show($"Su tarjeton grafico es {actual.computadora.tarjetaVideo}\n"
                    +$"La memoria Ram es de {actual.computadora.memoriaRam}\n"
                    +$"La SSD que eligio es {actual.computadora.SSD}\n"
                    +$"Sus luces gaming son {actual.computadora.rgb}");
                actual = actual.siguiente;
            }

        }
        public void BuscarElemento(string palabra)
        {
            //string palabra = formularioListas.txtTarjetaVideoList.Text;
            bool encontrado = false;
            if (ListaVacia())
                MessageBox.Show("El modelo con esa tarjeta de video no esta disponible");

            else
            {
                Nodo actual = _primero;
                while (actual != null)
                {
                    if (string.Compare(palabra, actual.computadora.tarjetaVideo) == 1)
                    /*(actual.computadora.tarjetaVideo == formularioListas.txtTarjetaVideoList.Text)*/

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
            Nodo nuevoNodo;
            nuevoNodo= new Nodo(computadora);
            nuevoNodo.siguiente = _primero;
            _primero = nuevoNodo;
        }

        public void InsertarMedioLista(Computadora computadora)
        {
            int longitud = LongitudLista();
            int medio =0;
            medio = longitud/2;
            Nodo actual = _primero;
            Nodo anterior = null;
            //MessageBox.Show(_primero.computadora.SSD);
            int contador = 1;
            while (actual != null)
            {
                //if (Convert.ToUInt32(actual)==medio)
                if (contador==medio)

                {
                    actual.siguiente = new Nodo(computadora);
                    new Nodo(computadora).siguiente = actual;
                        break;
                }
               anterior = actual;
                actual = actual.siguiente;
                contador++;
            }
        }

    }
}
