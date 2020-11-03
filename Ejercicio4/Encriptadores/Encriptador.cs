using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4
{
    public abstract class Encriptador:IEncriptador
    {
        protected String iNombre;

        /// <summary>
        /// Clase Encriptador
        /// </summary>
        /// <param name="pNombre">Codigo del tipo de encriptador</param>
        public Encriptador(String pNombre)
        {
            this.iNombre = pNombre;
        }

        /// <summary>
        /// Devuelve el nombre del encriptador
        /// </summary>
        public String Nombre { get { return this.iNombre; } }

        /// <summary>
        /// Encripta una cadena de texto
        /// </summary>
        /// <param name="pCadena">Cadena de texto a encriptar</param>
        /// <returns>Devuelve el texto encriptado</returns>
        public abstract String Encriptar(String pCadena);

        /// <summary>
        /// Desencripta una cadena de texto
        /// </summary>
        /// <param name="pCadena">Cadena de texto a desencriptar</param>
        /// <returns>Devuelve el texto desencriptado</returns>
        public abstract String Desencriptar(String pCadena);
    }
}
