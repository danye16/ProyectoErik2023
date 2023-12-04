using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoErik2023.Datos.Pilas
{
    public class pila
    {
       private const int TamanioMaximo = 3;
            private Computadora[] pilaComputadoras = new Computadora[TamanioMaximo];
            private int indice = 0;



            public void AgregarPc(string tarjetaVideo, string memoriaRam, string ssd, string rgb)
            {
                if (indice < TamanioMaximo)
                {
                    Computadora compu = new Computadora();
                    compu.memoriaRam = memoriaRam;
                    compu.SSD = ssd;
                    compu.tarjetaVideo = tarjetaVideo;
                    compu.rgb = rgb;

                    pilaComputadoras[indice] = compu;
                    indice++;

                    MessageBox.Show("Se guardaron los datos exitosamente");

                  
                }
                else
                {
                    MessageBox.Show("La pila está llena, no se pueden agregar más elementos.");
                }
            }

            public void MostrarPc()
            {
                for (int i = indice - 1; i >= 0; i--)
                {
                    MessageBox.Show($"Pc {i}\n" +
                        $"Su tarjeta de video es: {pilaComputadoras[i].tarjetaVideo}\n" +
                        $"La memoria RAM es: {pilaComputadoras[i].memoriaRam}\n" +
                        $"El SSD es: {pilaComputadoras[i].SSD}\n" +
                        $"El RGB es: {pilaComputadoras[i].rgb}");
                }
            }

            public void EliminarPc()
            {
                if (indice > 0)
                {
                    indice--;
                    pilaComputadoras[indice] = null;
                    MessageBox.Show("Se eliminó la computadora en la parte superior de la pila.");
                }
                else
                {
                    MessageBox.Show("La pila está vacía, no se puede eliminar.");
                }
            }

            
        }
    }


