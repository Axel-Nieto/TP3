using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    public class ContextoOtorgarTurno
    {
        IOtorgarTurno iEstrategiaOtorgarTurno;

        /// <summary>
        /// Clase contexto para contener un objeto de la estrategia 'Otorgar Turno'
        /// </summary>
        /// <param name="pEstrategiaOtorgarTurno">Objeto que puede hacer uso de la Interfaz IOtorgarTurno</param>
        public ContextoOtorgarTurno(IOtorgarTurno pEstrategiaOtorgarTurno)
        {
            this.iEstrategiaOtorgarTurno = pEstrategiaOtorgarTurno;
        }

        /// <summary>
        /// Ejecuta el metodo OtorgarTurno de un objeto que hace uso de la interfaz IOtorgarTurno
        /// </summary>
        /// <param name="repositorio">Repositorio que almacena los pacientes de las salas</param>
        public void OtorgarTurno(RepositorioPacientes repositorio)
        {
            iEstrategiaOtorgarTurno.OtorgarTurno(repositorio);
        }
    }
}
