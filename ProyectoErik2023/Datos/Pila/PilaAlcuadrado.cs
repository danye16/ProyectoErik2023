using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoErik2023.Datos.Pila
{
    public   class PilaAlcuadrado
    {
        //POSICION ES IGUAL A CIMA
        private Computadora[] computadoraPila;
        private int _posicionPila;
        int _longitudPilaMaximo = 200;
        private Computadora[] computadoraPila2;
        private int _posicionPila2;
        public PilaAlcuadrado()
        {
            _posicionPila = -1;
            computadoraPila = new Computadora[_longitudPilaMaximo];

        }

        public bool PilaVacia()
        {
            if (_posicionPila == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PilaLlena()
        {
            return _posicionPila == _longitudPilaMaximo - 1 ? true : false;
        }

        public int LongitudPila()
        {
            if (PilaVacia())
            {
                return -1;
            }
            else
            {
                return _longitudPilaMaximo;
            }
        }

        public int CantidadElemento()
        {
            return _posicionPila + 1;
        }

        public Computadora ValorCima()
        {
            return computadoraPila[_posicionPila];
        }

        public bool InsertarElemento(Computadora computadora)
        {
            if (PilaLlena())
            {
                MessageBox.Show("La pila esta llena ");
                return false;
            }
            else
            {
                _posicionPila++;
                computadoraPila[_posicionPila] = computadora;
                return true;
            }
        }

        public Computadora ExtraerElemento()         //ES ELIMINAR ELEMENTO DE LA CIMA
        {
            if (PilaVacia())
            {
                MessageBox.Show("La pila esta vacia ");
                return null;
            }
            else
            {
                Computadora temporal = computadoraPila[_posicionPila];
                _posicionPila--;
                return temporal;
            }
        }

        public bool Limpiar()
        {
            if (PilaVacia())
            {
                return false;
            }
            else
            {
                while (!PilaVacia())
                {
                    ExtraerElemento();
                }
            }
            return true;
        }



        
        public void Buscar(string computadoraBuscada)
        {
            bool encontrado = false;

            // Crear una pila auxiliar
            _posicionPila2 = -1;
            Computadora[] computadoraPila2 = new Computadora[_longitudPilaMaximo];

            // int posicionOriginal = _posicionPila;

            // Mientras la pila original no esté vacía
            while (!PilaVacia())
            {
                // Extraer el elemento de la cima de la pila original
                Computadora temporal = ExtraerElemento();

                // Si el elemento extraído es igual al buscado
                if (string.Compare(computadoraBuscada, temporal.tarjetaVideo) == 0)
                {
                    encontrado = true;
                    // No se inserta el elemento nuevamente en la pila original
                    MessageBox.Show("Elemento encontrado en la posición: " + (_posicionPila + 1));
                }

                // Insertar el elemento extraído en la pila auxiliar
                _posicionPila2++;
                computadoraPila2[_posicionPila2] = temporal;
            }

            // Restaurar la pila original
            while (_posicionPila2 >= 0)
            {
                Computadora temporal = computadoraPila2[_posicionPila2--];
                InsertarElemento(temporal);
            }

            if (!encontrado)
            {
                MessageBox.Show("Elemento no encontrado en la pila.");
            }
        }



    }
}
