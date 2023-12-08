using ProyectoErik2023.Datos.Pila;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoErik2023.Datos.Colas
{
    public class ColasAlcuadrado
    {
        public Computadora[] computadoraCola;
        private int _inicio;
        private int _final;
        private int _longitudColaMaximo = 3;

        public ColasAlcuadrado()
        {
            _inicio = -1;
            _final = -1;
            computadoraCola = new Computadora[_longitudColaMaximo];
        }


        public bool ColaVacia()
        {
            return _inicio == -1;
        }
        
        public bool ColaLlena()
        {
            return (_inicio == 0 && _final == _longitudColaMaximo - 1) || _final == (_inicio - 1) % (_longitudColaMaximo - 1);
        }

        public int LongitudCola()
        {
            if (ColaVacia())
                return -1;
            return _longitudColaMaximo;
        }

        public int CantidadElemento()
        {
            if (ColaVacia())
                return 0;
            if (_final >= _inicio)
                return _final - _inicio + 1;
            return _longitudColaMaximo - _inicio + _final + 1;
        }

        public Computadora FrenteCola()
        {
            if (ColaVacia())
                return null;
            return computadoraCola[_inicio];
        }

        public void InsertarElemento(Computadora computadora)
        {
            if (ColaLlena())
            {
                MessageBox.Show("La cola está llena.");
                return;
            }

            if (_inicio == -1)
                _inicio = 0;

            _final = (_final + 1) % _longitudColaMaximo;
            computadoraCola[_final] = computadora;
        }

        public Computadora EliminarElemento()
        {
            if (ColaVacia())
            {
                MessageBox.Show("La cola está vacía.");
                return null;
            }

            Computadora temp = computadoraCola[_inicio];

            if (_inicio == _final)
            {
                _inicio = -1;
                _final = -1;
            }
            else
            {
                _inicio = (_inicio + 1) % _longitudColaMaximo;
            }

            return temp;
        }
        public void Buscar(string tarjetaBuscada)
        {
            bool encontrado = false;
            int posicionActual = _inicio;

            while (posicionActual != (_final + 1) % _longitudColaMaximo)
            {
                if (string.Compare(tarjetaBuscada, computadoraCola[posicionActual].tarjetaVideo) == 0)
                {
                    encontrado = true;
                    MessageBox.Show("Elemento encontrado en la posición: " + (posicionActual + 1));
                    break;
                }
                posicionActual = (posicionActual + 1) % _longitudColaMaximo;
            }

            if (!encontrado)
            {
                MessageBox.Show("Elemento no encontrado en la cola.");
            }
        }

      

        public bool BuscarPorTarjeta(string tarjetaBuscada, out Computadora computadoraEncontrada)
        {
            int posicionActual = _inicio;
            while (posicionActual != (_final + 1) % _longitudColaMaximo)
            {
                if (computadoraCola[posicionActual].tarjetaVideo == tarjetaBuscada)
                {
                    computadoraEncontrada = computadoraCola[posicionActual];
                    return true;
                }
                posicionActual = (posicionActual + 1) % _longitudColaMaximo;
            }

            computadoraEncontrada = null;
            return false;
        }

        public bool ActualizarComputadora(Computadora computadoraModificada)
        {
            ColasAlcuadrado colaAuxiliar = new ColasAlcuadrado(); 

            bool encontrado = false;
            int posicionActual = _inicio;

            while (posicionActual != (_final + 1) % _longitudColaMaximo)
            {
                if (computadoraCola[posicionActual].tarjetaVideo == computadoraModificada.tarjetaVideo)
                {
                   
                    colaAuxiliar.InsertarElemento(computadoraModificada);
                    encontrado = true;
                }
                else
                {
                    colaAuxiliar.InsertarElemento(computadoraCola[posicionActual]); 
                }

                posicionActual = (posicionActual + 1) % _longitudColaMaximo;
            }

            if (encontrado)
            {
                
                computadoraCola = colaAuxiliar.computadoraCola;
                _inicio = colaAuxiliar._inicio;
                _final = colaAuxiliar._final;
            }

            return encontrado;
        }


        public void Limpiar()
        {
            _inicio = -1;
            _final = -1;
            computadoraCola = new Computadora[_longitudColaMaximo];
        }


    }
}       


