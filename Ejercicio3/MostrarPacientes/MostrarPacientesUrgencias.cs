using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    public class MostrarPacientesUrgencias: IMostrarPacientes
    {
        /// <summary>
        /// Imprime en consola todos los objetos de un arreglo
        /// </summary>
        /// <param name="pLista">Arreglo de objetos</param>
        public void MostrarPacientes(Object[] pLista)
        {
            Console.Clear();
            Object[] pacientes = new PacienteUrgencia[pLista.Length];
            pacientes = pLista;
            foreach (PacienteUrgencia paciente in pacientes)
            {
                if (paciente is null) { break; }
                else
                {
                    Console.WriteLine(String.Format("DNI del paciente: {0}      Prioridad: {1}", paciente.Dni,paciente.Nivel));
                }
            }
        }
    }
}
