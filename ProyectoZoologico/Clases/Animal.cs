using ProyectoZoologico.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoZoologico.Clases
{


    public class Animal
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Comida { get; set; } 
        
        public double Hambre { get; set; }
        public double Salud {  get; set; }
        public Persona persona { get; set; }
        public Animal() { }

        public Animal (string name, string description,string comida,Persona persona)
        {
            this.Name = name;
            this.Description = description;
            this.Comida = comida;
            this.Hambre = 0;
            this.Salud = 100;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }


    public class Mamifero : Animal , IAnimal
    {
        public Mamifero(string name, string description, string comida,Persona persona) : base(name, description, comida,persona)
        {
        }

        public void Amamantar()
        {
            Console.WriteLine($"{Name}esta amamantando.");
        }
        public void comer() { Console.WriteLine($"{ Name} esta comiendo carne y verduras"); }
    }

    public class Ave : Animal,IAnimal 
    {
        public Ave(string name, string description, string comida, Persona persona) : base(name, description, comida, persona)
        {
        }

        public void Volar()
        {
            Console.WriteLine($"{Name} está volando.");
        }
        public void comer() { Console.WriteLine($"{Name} esta comiendo alimento balanceado"); }
    }

    public class Pez : Animal,IAnimal
    {
        public Pez(string name, string description, string comida, Persona persona) : base(name, description, comida, persona)
        {
        }

        public void Nadar()
        {
            Console.WriteLine($"{Name} está nadando.");
        }

        public void comer() { Console.WriteLine("animal comiendo"); }
    }





}
