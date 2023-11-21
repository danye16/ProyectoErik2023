using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoErik2023.Listas.Nose
{
    public class Nodo
    {
        private Computadora _computadora { get; set; }
        private Nodo _siguiente { get; set; }
        public Nodo(Computadora computadora) 
        {
            _computadora= computadora;
            _siguiente = null;
        }
        public Nodo(Computadora computadora, Nodo siguiente)
        {
            _computadora= computadora;
            _siguiente= siguiente;
        }
        public Computadora computadora { get; set; }
        public Nodo siguiente { get; set; }
    }
}
