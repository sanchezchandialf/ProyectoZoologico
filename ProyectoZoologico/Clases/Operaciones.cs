using ProyectoZoologico.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoZoologico.Clases
{
    public class Operaciones 
    {

       
        public void AsignarCuidador(Zoologico zoo,Cuidador cuidador)
        {
            Console.WriteLine($"{cuidador}CuidadorrAsignado");
        }
        public void agregarAnimal(Zoologico zoo, IAnimal animal)
        {
            zoo.animales.AddLast(animal);
        }

    }
}
