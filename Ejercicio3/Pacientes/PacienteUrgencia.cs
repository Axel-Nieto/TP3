using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    public class PacienteUrgencia:Paciente
    {
        private int iNivel; 

        public PacienteUrgencia(String pDni, int pNivel): base(pDni)
        {
            this.iNivel = pNivel;
            this.iDni = pDni;
        }

        /// <summary>
        /// Devuelve el nivel
        /// </summary>
        public int Nivel { get { return this.iNivel; } }
    }
}
