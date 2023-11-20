using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoErik2023
{
    public class Computadora
    {
       public string memoriaRam { get; set; }
        public string SSD { get; set; }
        public string tarjetaVideo { get; set; }
        public string rgb { get; set; }

      public  Computadora[] computadoras {  get; set; }

        public Computadora()
        {
            memoriaRam = "";
            SSD = "";
            tarjetaVideo = "";
            rgb = "";
        }

    }
}
