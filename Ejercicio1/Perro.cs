using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    public class Perro: Animal
    {
        /// <summary>
        /// Ordena al perro que haga ruido
        /// </summary>
        public override void HacerRuido()
        {
            Console.WriteLine("Guau");
        }
    }
}
