using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Ejercicio4
{
   
    public class EncriptadorTBinaria:Encriptador
    {
        /// <summary>
        /// Crea un objeto de la clase EncriptadorTBinaria
        /// </summary>
        /// <param name="pNombre">Nombre del encriptador</param>
        public EncriptadorTBinaria(String pNombre) : base(pNombre)
        {

        }

        /// <summary>
        /// Encripta una cadena de texto
        /// </summary>
        /// <param name="pCadena">Cadena a encriptar</param>
        /// <returns>Devuelve la cadena encriptada</returns>
        public override String Encriptar(String pCadena)
        {
            string binaria = "";
            int i = 0;
            while (i < pCadena.Length)
            {
                if(i+1 < pCadena.Length)
                {
                    binaria = binaria + pCadena[i + 1].ToString() + pCadena[i].ToString();
                }
                else
                {
                    binaria = binaria + pCadena[i].ToString();
                }
                i += 2;
            }
            return binaria;
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
