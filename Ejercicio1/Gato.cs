using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    class Gato: Animal
    {
        /// <summary>
        /// Ordena al gato que haga ruido
        /// </summary>
        public override void HacerRuido()
        {
            Console.WriteLine("Miau");
        }
    }
}
