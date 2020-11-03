using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3.Visual
{
    public class MenuSalaUrgencias:Menu
    {
        public override void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("Sala de Urgencias:" + '\n');
            Console.WriteLine("1.Atender paciente");
            Console.WriteLine("2.Otorgar turno");
            Console.WriteLine("3.Mostrar turnos pendientes");
        }
    }
}
