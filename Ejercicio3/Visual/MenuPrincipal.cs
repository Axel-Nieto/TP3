using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Ejercicio3.Visual
{
    public class MenuPrincipal: Menu
    {
        public override void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("BIENVENIDO AL HOSPITAL 'PUNTO 3'"+'\n');
            Console.WriteLine("Seleccione la sala que desea atender: "+'\n');
            Console.WriteLine("1. Sala de consultas");
            Console.WriteLine("2. Sala de urgencias"+'\n');
            Console.WriteLine("0. Salir");
        }

        
    }
}
