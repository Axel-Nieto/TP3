using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    public interface IRepositorioPacientes
    {
        public void EliminarConsulta(Paciente pPaciente);
        public void EliminarUrgencia(PacienteUrgencia pPaciente);
        public void AgregarConsulta(Paciente pPaciente);
        public void AgregarUrgencia(PacienteUrgencia pPaciente);
    }
}
