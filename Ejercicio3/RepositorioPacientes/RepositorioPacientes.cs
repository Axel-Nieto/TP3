using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    public class RepositorioPacientes : IRepositorioPacientes
    {
        /* Esta clase simula una base de datos en memoria, la cual para simplificar el
         ejercicio genera de manera aleatoria dos arreglos de pacientes (en cada una no se repiten
        los pacientes), a partir del arreglo iPacientes*/

        private Paciente[] iPacientes = new Paciente[] {
            new Paciente("30000000"),
            new Paciente("30000001"),
            new Paciente("30000002"),
            new Paciente("30000003"),
            new Paciente("30000004"),
            new Paciente("30000005"),
            new Paciente("30000006"),
            new Paciente("30000007"),
            new Paciente("30000008"),
            new Paciente("30000009"),
            new Paciente("30000010"),
            new Paciente("30000011"),
            new Paciente("30000012"),
            new Paciente("30000013"),
            new Paciente("30000014"),
            new Paciente("30000015"),
            new Paciente("30000016"),
            new Paciente("30000017"),
            new Paciente("30000018"),
            new Paciente("30000019"),
            new Paciente("30000020"),
            new Paciente("30000021"),
            new Paciente("30000022"),
            new Paciente("30000023"),
            new Paciente("30000024"),
            new Paciente("30000025"),
            new Paciente("30000026"),
            new Paciente("30000027"),
            new Paciente("30000028"),
            new Paciente("30000029")
        };

        private Paciente[] iPacientesConsulta = new Paciente[10];

        private Paciente[] iPacientesUrgencia = new PacienteUrgencia[10];

        public RepositorioPacientes()
        {
            GenerarListaPacientesConsulta();
            GenerarListaPacientesUrgencia();
        }

        private Paciente[] Pacientes { get { return this.iPacientes; } }
        public Paciente[] PacientesConsulta { get { return this.iPacientesConsulta; } }
        public Paciente[] PacientesUrgencia { get { return this.iPacientesUrgencia; } }

        private Paciente TomarPacienteRandom()
        {
            Random random = new Random();
            return this.Pacientes[random.Next(0, 30)];
        }

        private int TomarNivelRandom()
        {
            Random random = new Random();
            return random.Next(1, 6);
        }

        private bool ExistePaciente(Paciente pPaciente, Paciente[] pPacientes)
        {
            bool existe = false;
            foreach (Paciente paciente in pPacientes)
            {
                if (paciente != null)
                {
                    if (paciente.Dni == pPaciente.Dni)
                    {
                        existe = true;
                    }
                }
                else break;
            }
            return existe;
        }

        private void GenerarListaPacientesConsulta()
        {
            Paciente paciente;            
            for (int i = 0; i < 10;)
            {
                paciente = TomarPacienteRandom();
                if (ExistePaciente(paciente, this.PacientesConsulta) == false)
                {
                    this.PacientesConsulta[i] = paciente;
                    i++;
                }
            }
        }

        private void GenerarListaPacientesUrgencia()
        {
            Paciente paciente;
            for (int i = 0; i < 10;)
            {
                paciente = TomarPacienteRandom();
                if (ExistePaciente(paciente, this.PacientesUrgencia) == false)
                {
                    this.PacientesUrgencia[i] = new PacienteUrgencia(paciente.Dni,TomarNivelRandom());
                    i++;
                }
            }
        }

        public void GuardarCambiosConsulta(Paciente[] pPacientes)
        {
            this.iPacientesConsulta = pPacientes;
        }

        public void GuardarCambiosUrgencia(Paciente[] pUrgencias)
        {
            this.iPacientesUrgencia = pUrgencias;
        }

        public void EliminarConsulta(Paciente pPaciente)
        {
            int pos = 0;
            Paciente[] pacientes = new Paciente[this.iPacientesConsulta.Length];
            foreach (Paciente paciente in this.iPacientesConsulta)
            {
                if(paciente is null)
                {                    
                    break;
                }
                if(paciente.Dni != pPaciente.Dni)
                {
                    pacientes[pos] = paciente;
                    pos++;
                }
            }
            GuardarCambiosConsulta(pacientes);
        }

        public void EliminarUrgencia(PacienteUrgencia pPaciente)
        {
            int pos = 0;
            PacienteUrgencia[] pacientes = new PacienteUrgencia[this.iPacientesUrgencia.Length];
            foreach (PacienteUrgencia paciente in this.iPacientesUrgencia)
            {
                if (paciente is null)
                {
                    break;
                }
                if (paciente.Dni != pPaciente.Dni)
                {
                    pacientes[pos] = paciente;
                    pos++;
                }
            }
            GuardarCambiosUrgencia(pacientes);
        }

        public void AgregarConsulta(Paciente pPaciente)
        {
            int pos = 0;
            foreach(Paciente paciente in iPacientesConsulta)
            {
                if (paciente is null)
                {
                    iPacientesConsulta[pos] = pPaciente;
                    break;
                }
                else pos++;
            }
        }

        public void AgregarUrgencia(PacienteUrgencia pPaciente)
        {
            int pos = 0;
            foreach (PacienteUrgencia paciente in iPacientesUrgencia)
            {
                if (paciente is null)
                {
                    iPacientesUrgencia[pos] = pPaciente;
                    break;
                }
                else pos++;
            }
        }
    }
}
