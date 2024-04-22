using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoZoologico.Clases
{
    public class PlantasCarnivoras
    {
        public string name { get; set; }
        public string tipo { get; set; }
        public string tipocarnivoro { get; set; }



        public PlantasCarnivoras() { }

        public PlantasCarnivoras(string name, string tipo, string tipocarnivoro)
        {
            this.name = name;
            this.tipo = tipo;
            this.tipocarnivoro = tipocarnivoro;

        }

       
    }
}
