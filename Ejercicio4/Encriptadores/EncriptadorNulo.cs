using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4
{
    public sealed class EncriptadorNulo: Encriptador
    {
        /// <summary>
        /// Crea un objeto de la clase EncriptadorNulo
        /// </summary>
        /// <param name="pNombre">Nombre del encriptador</param>
        public EncriptadorNulo(String pNombre): base(pNombre)
        {
        }

        /// <summary>
        /// Encripta una cadena de texto
        /// </summary>
        /// <param name="pCadena">Cadena a encriptar</param>
        /// <returns>Devuelve la cadena encriptada</returns>
        public override String Encriptar(String pCadena)
        {
            return pCadena;
        }

        /// <summary>
        /// Desencripta una cadena de texto
        /// </summary>
        /// <param name="pCadena">Cadena de texto a desencriptar</param>
        /// <returns>Devuelve el texto desencriptado</returns>
        public override String Desencriptar(String pCadena)
        {
            return pCadena;
        }
    }
}
