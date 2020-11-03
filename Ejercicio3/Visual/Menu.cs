using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3.Visual
{
    public abstract class Menu
    {
        public abstract void MostrarMenu();

        public int PedirOpcion()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
