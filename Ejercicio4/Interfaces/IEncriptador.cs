using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4
{
    public interface IEncriptador
    {
        /// <summary>
        /// Encripta una cadena de texto
        /// </summary>
        /// <param name="pCadena">Cadena a encriptar</param>
        /// <returns>Devuelve la cadena encriptada</returns>
        public String Encriptar(String pCadena);

        /// <summary>
        /// Desencripta una cadena de texto
        /// </summary>
        /// <param name="pCadena">Cadena a desencriptar</param>
        /// <returns>Devuelve la cadena desencriptada</returns>
        public String Desencriptar(String pCadena);
    }
}
