using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    public class ContextoMostrarPacientes
    {
        IMostrarPacientes iEstrategiaMostrarPacientes;

        /// <summary>
        /// Clase contexto para contener un objeto de la estrategia 'Mostrar Pacientes'
        /// </summary>
        /// <param name="pEstrategiaMostrarPacientes">Objeto que puede hacer uso de la Interfaz IMostrarPacientes</param>
        public ContextoMostrarPacientes(IMostrarPacientes pEstrategiaMostrarPacientes)
        {
            this.iEstrategiaMostrarPacientes = pEstrategiaMostrarPacientes;
        }

        /// <summary>
        /// Ejecuta el metodo MostrarPacientes de un objeto que hace uso de la interfaz IMostrarPacientes
        /// </summary>
        /// <param name="pLista">Array de objetos</param>
        public void MostrarPacientes(Object[] pLista)
        {
            iEstrategiaMostrarPacientes.MostrarPacientes(pLista);
        }
    }
}
