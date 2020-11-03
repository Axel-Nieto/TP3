using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    public class AtenderTriaje: IAtender
    {
        /// <summary>
        /// Devuelve el primer objeto de un arreglo
        /// </summary>
        /// <param name="pLista">Arreglo de objetos</param>
        /// <returns>Devuelve el primer objeto del arreglo con prioridad 1. 
        /// De no existir dicho objeto, se procedera a obtener el primer objeto con prioridad 2,
        /// y asi sucesivamente hasta la prioridad 5, o null si la lista esta vacia</returns>
        public Object Atender(Object[] pLista)
        {
            Object[] pacientes = new PacienteUrgencia[pLista.Length];
            pacientes = pLista;
            if (pLista[0] != null)
            {
                for (int i = 1; i < 6; i++)
                {
                    foreach (PacienteUrgencia paciente in pacientes)
                    {
                        if(paciente is null) { break; }
                        if (paciente.Nivel == i)
                        {
                            return paciente;
                        }
                    }
                }
                return null;
            }
            else return null;
        }
    }
}
