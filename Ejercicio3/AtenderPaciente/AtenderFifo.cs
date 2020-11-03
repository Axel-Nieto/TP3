using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    public class AtenderFifo: IAtender
    {
        /// <summary>
        /// Devuelve el primer objeto de un arreglo
        /// </summary>
        /// <param name="pLista">Arreglo de objetos</param>
        /// <returns>Devuelve el primer objeto del arreglo, o null si la lista esta vacia</returns>
        public Object Atender(Object[] pLista)
        {
            if (pLista[0] != null)
            {
                return pLista[0];
            }
            else return null;
        }
    }
}
