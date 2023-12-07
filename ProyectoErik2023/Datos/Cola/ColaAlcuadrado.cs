using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoErik2023.Datos.Cola
{
    public class ColaAlcuadrado
    {
        public Computadora[] computadoraCola;
        public int frente;
        public int final;
        public int capacidadCola;
        public int tamaño;

        public ColaAlcuadrado(int capacidad)
        {
            capacidadCola = capacidad;
            frente = 0;
            final = -1;
            tamaño = 0;
            computadoraCola = new Computadora[capacidadCola];
        }

        public bool ColaVacia()
        {
            return tamaño == 0;
        }

        public bool ColaLlena()
        {
            return tamaño == capacidadCola;
        }

        public int LongitudCola()
        {
            return tamaño;
        }

        public void AgregarElemento(Computadora computadora)
        {
            if (ColaLlena())
            {
                MessageBox.Show("La cola está llena");
            }
            else
            {
                final = (final + 1) % capacidadCola;
                computadoraCola[final] = computadora;
                tamaño++;
            }
        }

        public Computadora SacarElemento()
        {
            if (ColaVacia())
            {
                MessageBox.Show("La cola está vacía");
                return null;
            }
            else
            {
                Computadora temporal = computadoraCola[frente];
                frente = (frente + 1) % capacidadCola;
                tamaño--;
                return temporal;
            }
        }

        public bool LimpiarCola()
        {
            if (ColaVacia())
            {
                return false;
            }
            else
            {
                while (!ColaVacia())
                {
                    SacarElemento();
                }
            }
            return true;

        }

        public void BuscarEnCola(string computadoraBuscada)
        {
            bool encontrado = false;

            for (int i = frente; i <= final; i++)
            {
                if (string.Compare(computadoraBuscada, computadoraCola[i].tarjetaVideo) == 0)
                {
                    encontrado = true;
                    MessageBox.Show($"Elemento encontrado ({computadoraBuscada}) en la posición: {i + 1}");
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("Elemento no encontrado en la cola.");
            }
        }

        public void OrdenarAscendente()
        {
            int n = LongitudCola();

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = frente; j < frente + n - i - 1; j++)
                {
                    int index1 = j % capacidadCola;
                    int index2 = (j + 1) % capacidadCola;

                    if (string.Compare(computadoraCola[index1].tarjetaVideo, computadoraCola[index2].tarjetaVideo) > 0)
                    {
                        Computadora temp = computadoraCola[index1];
                        computadoraCola[index1] = computadoraCola[index2];
                        computadoraCola[index2] = temp;
                    }
                }
            }
        }
        public void OrdenarDescendente()
        {
            int n = LongitudCola();

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = frente; j < frente + n - i - 1; j++)
                {
                    int index1 = j % capacidadCola;
                    int index2 = (j + 1) % capacidadCola;

                    if (string.Compare(computadoraCola[index1].tarjetaVideo, computadoraCola[index2].tarjetaVideo) < 0)
                    {
                        Computadora temp = computadoraCola[index1];
                        computadoraCola[index1] = computadoraCola[index2];
                        computadoraCola[index2] = temp;
                    }
                }
            }
        }
    }
    //public const int TamanioMaximo = 5;
    //public int aber = TamanioMaximo;
    //public Computadora[] computadoraCola = new Computadora[TamanioMaximo];
    //private int frente = -1;
    //private int final = -1;
    //public int Frente => frente;
    //public int Final => final;

    //public bool ColaVacia()
    //{
    //    return frente == -1;
    //}

    //public bool ColaLlena()
    //{
    //    return (frente == 0 && final == TamanioMaximo - 1) || frente == final + 1;
    //}

    //public int LongitudCola()
    //{
    //    if (ColaVacia())
    //    {
    //        return 0;
    //    }
    //    else
    //    {
    //        return (TamanioMaximo - frente + final + 1) % TamanioMaximo;
    //    }
    //}

    //public void Encolar(Computadora computadoraCola1)
    //{
    //    if (ColaLlena())
    //    {
    //        MessageBox.Show("La cola está llena");
    //    }
    //    else
    //    {
    //        if (frente == -1)
    //        {
    //            frente = 0;
    //        }
    //        final = (final + 1) % TamanioMaximo;
    //        computadoraCola[final] = computadoraCola1;
    //    }
    //}

    //public Computadora Desencolar()
    //{
    //    if (ColaVacia())
    //    {
    //        MessageBox.Show("La cola está vacía");
    //        return null;
    //    }
    //    else
    //    {
    //        Computadora computadoraCola1 = computadoraCola[frente];
    //        if (frente == final)
    //        {
    //            frente = -1;
    //            final = -1;
    //        }
    //        else
    //        {
    //            frente = (frente + 1) % TamanioMaximo;
    //        }
    //        return computadoraCola1;
    //    }
    //}

    //public void Buscar(string computadoraBuscada)
    //{
    //    bool encontrado = false;
    //    int indice = frente;

    //    while (indice != (final + 1) % TamanioMaximo)
    //    {
    //        if (string.Compare(computadoraBuscada, computadoraCola[indice].tarjetaVideo) == 0)
    //        {
    //            encontrado = true;
    //            MessageBox.Show("Elemento encontrado en la posición: " + indice);
    //            break;
    //        }
    //        indice = (indice + 1) % TamanioMaximo;
    //    }

    //    if (!encontrado)
    //    {
    //        MessageBox.Show("Elemento no encontrado en la cola.");
    //    }
    //}













}
