using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    public class OtorgarTurnoConsulta:IOtorgarTurno
    {
        /// <summary>
        /// Agrega un nuevo turno a una lista de pacientes del repositorio
        /// </summary>
        /// <param name="pRepositorioPacientes"></param>
        public void OtorgarTurno(RepositorioPacientes pRepositorioPacientes)
        {
            Console.Clear();
            if (pRepositorioPacientes.PacientesConsulta[pRepositorioPacientes.PacientesConsulta.Length - 1] is null)
            {
                Console.WriteLine("Ingrese el dni del paciente: ");
                String dni = Console.ReadLine();
                Paciente paciente = new Paciente(dni);
                pRepositorioPacientes.AgregarConsulta(paciente);
                Console.WriteLine("Turno añadido con exito");
            }
            else
            {                
                Console.WriteLine("Ya fueron otorgados todos los turnos, intente nuevamente mas tarde");
            }
        }
    }
}
