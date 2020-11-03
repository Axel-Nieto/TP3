using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    public class Fachada
    {
        private FachadaImp iFachadaImp;

        public Fachada(RepositorioPacientes pRepositorioPacientes)
        {
            this.iFachadaImp = new FachadaImp(pRepositorioPacientes);
        }

        /// <summary>
        /// Realiza una impresion del menu principal y solicita el ingreso de una opcion
        /// </summary>
        /// <returns>Regresa la opcion seleccionada</returns>
        public int MenuPrincipal()
        {
            return iFachadaImp.MenuPrincipal();
        }

        /// <summary>
        /// Realiza una impresion del menu para la sala de consultas y solicita el ingreso de una opcion
        /// </summary>
        /// <returns>Regresa la opcion seleccionada</returns>
        public int MenuSalaConsultas()
        {
            return iFachadaImp.MenuSalaConsultas();
        }

        /// <summary>
        /// Realiza una impresion del menu para la sala de urgencias y solicita el ingreso de una opcion
        /// </summary>
        /// <returns>Regresa la opcion seleccionada</returns>
        public int MenuSalaUrgencias()
        {
            return iFachadaImp.MenuSalaUrgencias();
        }

        /// <summary>
        /// Muestra los pacientes de la sala de consultas almacenados en el repositorio
        /// </summary>
        public void MostrarPacientesConsultas()
        {
            iFachadaImp.MostrarPacientesConsultas();
        }

        /// <summary>
        /// Muestra los pacientes de la sala de urgencias almacenados en el repositorio
        /// </summary>
        public void MostrarPacientesUrgencias()
        {
            iFachadaImp.MostrarPacientesUrgencias();
        }

        /// <summary>
        /// Selecciona al proximo paciente a atender en la sala de consultas
        /// </summary>
        public void AtenderPacienteConsulta()
        {
            iFachadaImp.AtenderPacienteConsulta();
        }

        /// <summary>
        /// Selecciona al proximo paciente a atender en la sala de urgencias
        /// </summary>
        public void AtenderPacienteUrgencia()
        {
            iFachadaImp.AtenderPacienteUrgencia();
        }

        /// <summary>
        /// Permite agregar un nuevo turno a la lista de pacientes en espera en la sala de consultas
        /// </summary>
        public void OtorgarTurnoConsulta()
        {
            iFachadaImp.OtorgarTurnoConsulta();
        }

        /// <summary>
        /// Permite agregar un nuevo turno a la lista de pacientes en espera en la sala de urgencias
        /// </summary>
        public void OtorgarTurnoUrgencia()
        {
            iFachadaImp.OtorgarTurnoUrgencia();
        }
    }
}
