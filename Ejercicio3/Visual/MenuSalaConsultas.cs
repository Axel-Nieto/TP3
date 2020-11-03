using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3.Visual
{
    public class MenuSalaConsultas: Menu
    {
        public override void MostrarMenu() {
            Console.Clear();
            Console.WriteLine("Sala de Consultas:"+'\n');
            Console.WriteLine("1.Atender paciente");
            Console.WriteLine("2.Otorgar turno");
            Console.WriteLine("3.Mostrar turnos pendientes");
        }
    }
}
