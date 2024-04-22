using ProyectoZoologico.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoZoologico.Clases
{
     public class Zoologico
    {
        public LinkedList<IAnimal>animales=new LinkedList<IAnimal>();
        public LinkedList<Cuidador>cuidadores=new LinkedList <Cuidador>();

        public Zoologico() { }
        public void agregarAnimal()
        {

        }
        public void agregarCuidadores(Zoologico zoo,Cuidador cuid) {
            zoo.cuidadores.AddLast(cuid);    }
        public void asignarCuidador() { }

    }
}
