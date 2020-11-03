using Ejercicio3.Visual;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    public class FachadaImp
    {
        private RepositorioPacientes iRepositorioPacientes;
        private Sala iSalaConsulta = new SalaConsulta();
        private Sala iSalaUrgencia = new SalaUrgencia();

        public FachadaImp(RepositorioPacientes pRepositorio)
        {
            this.iRepositorioPacientes = pRepositorio;
        }

        /// <summary>
        /// Realiza una impresion del menu principal y solicita el ingreso de una opcion
        /// </summary>
        /// <returns>Regresa la opcion seleccionada</returns>
        public int MenuPrincipal()
        {
            Menu menu = new MenuPrincipal();
            int opcion;
            menu.MostrarMenu();
            opcion = menu.PedirOpcion();
            return opcion;
        }

        /// <summary>
        /// Realiza una impresion del menu para la sala de consultas y solicita el ingreso de una opcion
        /// </summary>
        /// <returns>Regresa la opcion seleccionada</returns>
        public int MenuSalaConsultas()
        {
            Menu menu = new MenuSalaConsultas();
            int opcion;
            menu.MostrarMenu();
            opcion = menu.PedirOpcion();
            return opcion;
        }

        /// <summary>
        /// Realiza una impresion del menu para la sala de urgencias y solicita el ingreso de una opcion
        /// </summary>
        /// <returns>Regresa la opcion seleccionada</returns>
        public int MenuSalaUrgencias()
        {
            Menu menu = new MenuSalaUrgencias();
            int opcion;
            menu.MostrarMenu();
            opcion = menu.PedirOpcion();
            return opcion;
        }

        /// <summary>
        /// Muestra los pacientes de la sala de consultas almacenados en el repositorio
        /// </summary>
        public void MostrarPacientesConsultas()
        {
            iSalaConsulta.MostrarPacientes(iRepositorioPacientes.PacientesConsulta);
        }

        /// <summary>
        /// Muestra los pacientes de la sala de urgencias almacenados en el repositorio
        /// </summary>
        public void MostrarPacientesUrgencias()
        {
            iSalaUrgencia.MostrarPacientes(iRepositorioPacientes.PacientesUrgencia);
        }

        /// <summary>
        /// Selecciona al proximo paciente a atender en la sala de consultas
        /// </summary>
        public void AtenderPacienteConsulta()
        {
            Console.Clear();
            Paciente pacienteObtenido = (Paciente) (iSalaConsulta.Atender(iRepositorioPacientes.PacientesConsulta));
            if (pacienteObtenido is null)
            {
                Console.WriteLine("No hay pacientes en espera");
            }
            else
            {
                Console.WriteLine(String.Format("PROXIMO TURNO"));
                Console.WriteLine(String.Format("DNI: {0}", pacienteObtenido.Dni));
                iRepositorioPacientes.EliminarConsulta(pacienteObtenido);
            }
        }

        /// <summary>
        /// Selecciona al proximo paciente a atender en la sala de urgencias
        /// </summary>
        public void AtenderPacienteUrgencia()
        {
            Console.Clear();
            PacienteUrgencia pacienteObtenido = (PacienteUrgencia) iSalaUrgencia.Atender(iRepositorioPacientes.PacientesUrgencia);
            if (pacienteObtenido is null)
            {
                Console.WriteLine("No hay pacientes en espera");
            }
            else
            {
                Console.WriteLine(String.Format("PROXIMO TURNO"));
                Console.WriteLine(String.Format("DNI: {0}   Nivel: {1}", pacienteObtenido.Dni,pacienteObtenido.Nivel));
                iRepositorioPacientes.EliminarUrgencia(pacienteObtenido);
            }
        }

        /// <summary>
        /// Permite agregar un nuevo turno a la lista de pacientes en espera en la sala de consultas
        /// </summary>
        public void OtorgarTurnoConsulta()
        {
            iSalaConsulta.OtorgarTurno(iRepositorioPacientes);
        }

        /// <summary>
        /// Permite agregar un nuevo turno a la lista de pacientes en espera en la sala de urgencias
        /// </summary>
        public void OtorgarTurnoUrgencia()
        {
            iSalaUrgencia.OtorgarTurno(iRepositorioPacientes);
        }
    }
}
