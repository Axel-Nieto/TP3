using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio2
{
    public abstract class FiguraGeometrica
    {
        /// <summary>
        /// Calcula el area de la figura
        /// </summary>
        /// <returns>Devuelve un 'double' con 2 decimales</returns>
        public abstract double CalcularArea();

        /// <summary>
        /// Calcula el perimetro de la figura
        /// </summary>
        /// <returns>Devuelve un 'double' con 2 decimales</returns>
        public abstract double CalcularPerimetro();
    }
}
