using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    public class ContextoAtender
    {
        IAtender iEstrategiaAtender;

        /// <summary>
        /// Clase contexto para contener un objeto de la estrategia 'Atender'
        /// </summary>
        /// <param name="pEstrategiaAtender">Objeto que puede hacer uso de la Interfaz IAtender</param>
        public ContextoAtender(IAtender pEstrategiaAtender)
        {
            this.iEstrategiaAtender = pEstrategiaAtender;
        }

        /// <summary>
        /// Ejecuta el metodo atender de un objeto que hace uso de la interfaz IAtender
        /// </summary>
        /// <param name="pLista">Array de objetos</param>
        /// <returns>Devuelve el primer objeto de la lista</returns>
        public Object Atender(Object[] pLista)
        {
            return iEstrategiaAtender.Atender(pLista);
        }
    }
}
