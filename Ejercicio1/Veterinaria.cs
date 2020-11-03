using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    class Veterinaria
    {
        /// <summary>
        /// Crea un objeti de la clase Veterinaria
        /// </summary>
        public Veterinaria()
        {

        }

        /// <summary>
        /// Ordena a todos los animales de un arreglo a que hagan ruido
        /// </summary>
        /// <param name="pAnimales">Array de objetos de la clase Animal</param>
        public void AceptarAnimales(Animal[] pAnimales)
        {
            for (int i=0; i < pAnimales.Length; i++)
            {
                pAnimales[i].HacerRuido();
            }
        }
    }
}
