﻿using ProyectoZoologico.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoZoologico
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
           Zoologico zoonuevo = new Zoologico();
            Menu menu = new Menu();
            Menu.menu(zoonuevo);
        }
    }
}
