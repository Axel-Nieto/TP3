using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    public class OtorgarTurnoUrgencia: IOtorgarTurno
    {
        /// <summary>
        /// Agrega un nuevo turno a una lista de pacientes del repositorio
        /// </summary>
        /// <param name="pRepositorioPacientes"></param>
        public void OtorgarTurno(RepositorioPacientes pRepositorioPacientes)
        {
            Console.Clear();
            if (pRepositorioPacientes.PacientesUrgencia[pRepositorioPacientes.PacientesUrgencia.Length - 1] is null)
            {
                Console.Write("Ingrese el dni del paciente: ");
                String dni = Console.ReadLine();
                int nivel;
                do
                {
                    Console.Write("Ingrese el nivel de prioridad del paciente: ");
                    nivel = Convert.ToInt32(Console.ReadLine());
                } while (nivel < 1 && nivel > 5);
                PacienteUrgencia paciente = new PacienteUrgencia(dni, nivel);
                pRepositorioPacientes.AgregarUrgencia(paciente);
                Console.WriteLine("Turno añadido con exito");
            }
            else
            {               
                Console.WriteLine("Ya fueron otorgados todos los turnos, intente nuevamente mas tarde");
            }
        }
    }
}
