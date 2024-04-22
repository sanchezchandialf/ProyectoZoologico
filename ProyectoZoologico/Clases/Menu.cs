using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoZoologico.Clases
{
    public class Menu
    {
        public static void menu(Zoologico zoo)
        {
            Console.WriteLine("Bienvenido al Menu");
            Console.WriteLine("Elige entre las siguientes opciones");
            Console.WriteLine("1.Registrar Usuario");
            Console.WriteLine("2.Gestiones de Zoologico");
            Int32.TryParse(Console.ReadLine(), out int op);
            switch (op)
            {
                case 1:
                    soluciones.RegistrarCuidador(zoo);
                    Opmenu.Opciones(zoo);
                    break;
                case 2:
                    Opmenu.Opciones(zoo);
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
