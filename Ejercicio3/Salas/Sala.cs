using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    public abstract class Sala
    {
        /// <summary>
        /// Ejecuta el metodo atender de un objeto que hace uso de la interfaz IAtender
        /// </summary>
        /// <param name="pLista">Array de objetos</param>
        /// <returns>Devuelve el primer objeto de la lista</returns>
        public abstract Object Atender(Object[] pLista);

        /// <summary>
        /// Ejecuta el metodo MostrarPacientes de un objeto que hace uso de la interfaz IMostrarPacientes
        /// </summary>
        /// <param name="pLista">Array de objetos</param>
        public abstract void MostrarPacientes(Object[] pLista);

        /// <summary>
        /// Ejecuta el metodo OtorgarTurno de un objeto que hace uso de la interfaz IOtorgarTurno
        /// </summary>
        /// <param name="pRepositorioPacientes">Repositorio que almacena los pacientes de las salas</param>
        public abstract void OtorgarTurno(RepositorioPacientes pRepositorioPacientes);
    }
}
