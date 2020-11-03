using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    public abstract class Animal
    {
        /// <summary>
        /// Ordena al animal que corra
        /// </summary>
        public void Correr()
        {
            Console.WriteLine("Corriendo");
        }

        /// <summary>
        /// Ordena al animal que salte
        /// </summary>
        public void Saltar()
        {
            Console.WriteLine("Saltando");
        }

        /// <summary>
        /// Ordena al animal que haga ruido
        /// </summary>
        public abstract void HacerRuido();
    }
}
