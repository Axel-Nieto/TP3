using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4
{
    public class EncriptadorInversa: Encriptador
    {
        private static int iClavePublica = 4;

        /// <summary>
        /// Crea un objeto de la clase EncriptadorInversa
        /// </summary>
        /// <param name="pNombre">Nombre del encriptador</param>
        public EncriptadorInversa(String pNombre) : base(pNombre)
        {

        }

        /// <summary>
        /// Encripta una cadena de texto
        /// </summary>
        /// <param name="pCadena">Cadena a encriptar</param>
        /// <returns>Devuelve la cadena encriptada</returns>
        public override String Encriptar(String pCadena)
        {
            String inversa = "";
            for (int i = pCadena.Length-1; i >= 0; i--)
            {
                inversa = inversa + pCadena[i];
            }
            return inversa;
        }

        /// <summary>
        /// Desencripta una cadena de texto
        /// </summary>
        /// <param name="pCadena">Cadena de texto a desencriptar</param>
        /// <returns>Devuelve el texto desencriptado</returns>
        public override String Desencriptar(String pCadena)
        {           
            return Encriptar(pCadena);
        }
    }
}
