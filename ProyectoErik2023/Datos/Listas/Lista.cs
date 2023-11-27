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
                    if (string.Compare(palabra, actual.computadora.tarjetaVideo) == 0)
                    /*(actual.computadora.tarjetaVideo == formularioListas.txtTarjetaVideoList.Text)*/

                    {
                        MessageBox.Show($"si se encuentra la tarjeta {palabra} disponible");
                        encontrado = true;

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
                MessageBox.Show($"El modelo con la tarjeta de video {palabra} no esta disponible");
            }
        }

        public void AgregarLista (Computadora computadora)

        {
            if (ListaVacia())
            {
                _primero=_ultimo=new Nodo(computadora);
                MessageBox.Show("Computadora agregada con existo");
            }
            else
                _primero=new Nodo(computadora, _primero);
                MessageBox.Show("Computadora agregada con existo");

        }
        public void InsertarFinalLista (Computadora computadora)
        {
            if (ListaVacia())
            {
                _primero=_ultimo= new Nodo(computadora);
                MessageBox.Show("Computadora agregada con existo");

            }
            else
            {
                _ultimo= _ultimo.siguiente= new Nodo(computadora);
                MessageBox.Show("Computadora agregada con existo");
            }    
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
        public void OrdenarAscendenteLista()
        {
            if (ListaVacia())
            {
                MessageBox.Show("No hay productos disponibles");
            }
            else
            {
                bool centinela;
            do
            {
                centinela = false;
                Nodo actual = _primero;
                Nodo siguiente = _primero.siguiente;
                while (siguiente != null)
                {
                    if (string.Compare(actual.computadora.tarjetaVideo, siguiente.computadora.tarjetaVideo) < 0)
                    {//objeto auxitiliar para guardar temporalmente los datos
                        Computadora aux = actual.computadora;
                        actual.computadora = siguiente.computadora;
                        siguiente.computadora = aux;
                        centinela=true;
                    }
                    actual= siguiente;
                    siguiente = siguiente.siguiente;
                }
            } while (centinela);
                MessageBox.Show("Se ordenaron los productos de forma Ascendente");
            }
        }
        public void OrdenarDescendenteLista()
        {
            if (ListaVacia())
            {
                MessageBox.Show("No hay productos disponibles");
            }
            else { 
            bool centinela;
            do
            {
                centinela = false;
                Nodo actual = _primero;
                Nodo siguiente = _primero.siguiente;
                while (siguiente != null)
                {
                    if (string.Compare(actual.computadora.tarjetaVideo, siguiente.computadora.tarjetaVideo) > 0)
                    {//objeto auxitiliar para guardar temporalmente los datos
                        Computadora aux = actual.computadora;
                        actual.computadora = siguiente.computadora;
                        siguiente.computadora = aux;
                        centinela = true;
                    }
                    actual = siguiente;
                    siguiente = siguiente.siguiente;
                }
            } while (centinela);
                MessageBox.Show("Se ordenaron los productos de forma Descendente");

            }
        }
       

        public void VaciarLista()
        {
            _primero = _ultimo= null;
            MessageBox.Show("Se vacio la lista con todo los productos");
        }
        public void EliminarPrimeraPos()
        {
            if (_primero == _ultimo)
            {
                _primero = _ultimo = null;
            }
            else
                _primero = _primero.siguiente;
        }
    }
}
