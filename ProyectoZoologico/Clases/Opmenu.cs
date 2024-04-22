using ProyectoZoologico.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoZoologico.Clases
{
    public class Opmenu
    {

        public static void Opciones(Zoologico zoo)
        {
            int resp;
            do
            {
                Console.WriteLine("GESTIONES ADMINISTRATIVAS");
                Console.WriteLine("1.RegistrarCuidador");
                Console.WriteLine("2.Registrar Animal");
                Console.WriteLine("3.Seguimiento de Salud");
                Console.WriteLine("4.Alimentar Animal");
                Console.WriteLine("5.Generar Informe");
                Console.WriteLine("6.Asignar Cuidador Animal");
                Console.WriteLine("7.Eliminar/Editar Cuidador");
                Console.WriteLine("8.Salir");

                Int32.TryParse(Console.ReadLine(), out resp);
                switch (resp)
                {
                    case 1:
                        soluciones.Agregar(zoo);
                        break;
                    case 2:
                        soluciones.AgregarAnimal(zoo);
                        break;
                    case 3:
                        soluciones.Seguimiento(zoo);
                        break;
                    case 4:
                        soluciones.Alimentar(zoo);
                        break;
                    case 5:
                        soluciones.informe(zoo);
                        break;
                    case 6:
                        soluciones.AsignarCuida(zoo);
                        break;
                    case 7:
                        soluciones.MultiopcionCuidador(zoo);
                        break;
                    case 8:
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            } while (resp != 8); // El bucle continuará hasta que el usuario elija la opción 8 (Salir)
        }

    }
    public class soluciones {

        public static void Agregar(Zoologico zoo)
        {
            Console.WriteLine("Ingrese el nombre del cuidador");
            String Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su edad");
            Int32.TryParse(Console.ReadLine(), out int edad);
            Console.WriteLine("Ingrese Dni");
            Int32.TryParse(Console.ReadLine(), out int dni);
            Cuidador cuida = new Cuidador(Nombre, edad, dni, 0);
            zoo.cuidadores.AddLast(cuida);
            Console.WriteLine("Personal agregado correctamente");

        }
        public static void RegistrarCuidador(Zoologico zoo)
        {
            Console.WriteLine("Ingrese el nombre del cuidador:");
            string name = Console.ReadLine();

            Console.WriteLine("Ingrese la edad del cuidador:");
            int age = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el dni del cuidador:");
            int dni = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de puesto del cuidador (0 para Cuidador, 1 para Empleado, 2 para Administrador):");
            int numero = Int32.Parse(Console.ReadLine());

            Cuidador nuevoCuidador = new Cuidador(name, age, dni, numero);
            zoo.cuidadores.AddLast(nuevoCuidador);

            Console.WriteLine("Cuidador registrado exitosamente!");
        }
        public static void AgregarAnimal(Zoologico zoo)
        {
            Console.WriteLine("ingrese el nombre del animal");
            String nombre = Console.ReadLine();
            Console.WriteLine("ingrese una breve descripcion del animal");
            String des= Console.ReadLine();
            Console.WriteLine("De que especie es seleccion 1. si el animal es mamifero 2.Si es un Ave y 3 si es un pez ");
            Int32.TryParse(Console.ReadLine(), out int resp);
            switch(resp) { 
                
                
                case 1:
                    Mamifero mami = new Mamifero(nombre, des,"omniboro",null);

                    zoo.animales.AddLast(mami);
                    break;
                    
                    
                case 2:
                    Ave ave = new Ave(nombre, des, "herviboro",null);
                    zoo.animales.AddLast((ave));
                    break; 
                case 3:
                    Pez pez = new Pez(nombre, des, "herviboro",null);
                    zoo.animales.AddLast(pez);
                    break;

            }

        }
        public static void Seguimiento(Zoologico zoo)
        {

            foreach (Animal animalito in zoo.animales)
            {
                Console.WriteLine($"El animal {animalito.Name} tiene un estado de salud de {animalito.Salud}.");
            }
        }

        public static void AsignarCuida(Zoologico zoo)
        {
            Console.WriteLine("Seleccione un cuidador, ingrese su DNI");
            Int32.TryParse(Console.ReadLine(), out int resp);
            foreach (Persona persona in zoo.cuidadores)
            {
                if (persona.dni == resp)
                {
                    Persona cuidador = persona;
                    Console.WriteLine("El cuidador existe");
                    Console.WriteLine($"{persona.name} es el cuidador asignado");
                    Console.WriteLine("¿De qué especie es cuidador? 1. Si el animal es mamífero 2. Si es un ave y 3. Si es un pez");
                    Int32.TryParse(Console.ReadLine(), out int respu);
                    switch (respu)
                    {
                        case 1:
                            foreach (IAnimal animal in zoo.animales)
                            {
                                if (animal is Mamifero)
                                {
                                    ((Mamifero)animal).persona = cuidador;
                                }
                            }
                            break;
                        case 2:
                            foreach (IAnimal animal in zoo.animales)
                            {
                                if (animal is Ave)
                                {
                                    ((Ave)animal).persona = cuidador;
                                }
                            }
                            break;
                        case 3:
                            foreach (IAnimal animal in zoo.animales)
                            {
                                if (animal is Pez)
                                {
                                    ((Pez)animal).persona = cuidador;
                                }
                            }
                            break;
                        default:
                            Console.WriteLine("Opción no reconocida. Por favor, ingrese 1, 2 o 3.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("No existe el cuidador");
                }
            }
        }

        public static void Alimentar(Zoologico zoo)
        {
            foreach (Animal animalito in zoo.animales)
            {
                if (animalito.persona != null)
                {
                    Console.WriteLine($"{animalito.persona} es el cuidador y lo va a alimentar:");
                    IAnimal animalcome=animalito as IAnimal;
                    animalcome.comer();

                }
            }
        }
        public static void informe(Zoologico zoo)
        {
            foreach (Animal animalito in zoo.animales)
            {
                IAnimal animalmuestra = animalito as IAnimal;
                Console.WriteLine(animalmuestra);
            }
            foreach (Persona personita in zoo.cuidadores)
            {
                Console.WriteLine(personita);
            }
        }

        public static void MultiopcionCuidador(Zoologico zoo)
        {
            Console.WriteLine("Que operacion desea realizar 1.Eliminar 2.Modificar");
            Int32.TryParse(Console.ReadLine(), out var num);
            switch (num)
            {
                case 1:
                    Console.WriteLine("Proceso de eliminar Cuidador");
                    Console.WriteLine("seleccione el dni del usuario que sea eliminar");
                    Int32.TryParse(Console.ReadLine(), out var num1);

                    // Creamos una lista para almacenar los nodos de cuidadores a eliminar
                    List<LinkedListNode<Cuidador>> nodosAEliminar = new List<LinkedListNode<Cuidador>>();

                    for (var node = zoo.cuidadores.First; node != null; node = node.Next)
                    {
                        if (node.Value.dni == num1)
                        {
                            // Agregamos el nodo a la lista de nodos a eliminar
                            nodosAEliminar.Add(node);
                        }
                    }

                    // Eliminamos los nodos después de que el bucle for haya terminado
                    foreach (var node in nodosAEliminar)
                    {
                        zoo.cuidadores.Remove(node);
                        Console.WriteLine("persona eliminada");
                    }
                    break;
                case 2:
                    Console.WriteLine("seleccione el dni del usuario que sea modificar");
                    Int32.TryParse(Console.ReadLine(), out var num2);
                    Console.WriteLine("ingrese el nuevo nombre");
                    String nomn=Console.ReadLine();
                    Console.WriteLine("ingrese la edad");
                    Int32.TryParse(Console.ReadLine(), out int n);
                    Console.WriteLine("ingrese puesto de trabajo \"1Cuidador\", \"2.Empleado\", \"3.Administrador\"");
                    Int32.TryParse(Console.ReadLine(), out int numero);
                  

                    Persona personita =new Persona(nomn,n,num2,numero-1);
                    foreach(Persona personal in zoo.cuidadores)
                    {
                        if(personal.dni == num2)
                        {
                            personita = personal;
                            Console.WriteLine("USUARIO MODIFICADO");
                        }
                    }
                    break;
            }
        }



    }





}
