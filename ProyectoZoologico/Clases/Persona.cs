using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoZoologico.Clases
{
    public class Persona
    {
        public String name { get; set; }
        public int age { get; set; }
        public int dni { get; set; }
        public string puesto { get; set; }
         
      /*---------------------------------------------------------------*/
        public string[] trabajos = new string[] { "Cuidador", "Empleado", "Administrador" };

        public Persona() { }


        public Persona(string name, int age, int dni, int numero)
        {
            this.name = name;
            this.age = age;
            this.dni = dni;
            this.puesto = trabajos[numero];
            
        }
    }

    public class Cuidador : Persona
    {

    public Cuidador(string name, int age, int dni, int numero) : base(name, age, dni, numero) { }
        

    public void Alimentar() { }
    } 



    
}
