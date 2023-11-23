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
            this._computadora= computadora;
            this._siguiente = null;
        }
        public Nodo(Computadora computadora, Nodo siguientenodo)
        {
            this._computadora= computadora;
            this._siguiente= siguientenodo;
        }
        public Computadora computadora { get { return this._computadora; }  set{ this._computadora = value; } }
        public Nodo siguiente { get { return this._siguiente; } set { this._siguiente = value; } }
    }
}
