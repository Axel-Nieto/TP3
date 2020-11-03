using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    public class Paciente
    {
        protected String iDni;

        public Paciente(String pDni)
        {
            this.iDni = pDni;
        }

        /// <summary>
        /// Devuelve el Dni
        /// </summary>
        public String Dni { get { return this.iDni; } }
    }
}
