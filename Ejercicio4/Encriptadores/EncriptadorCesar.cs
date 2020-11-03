using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4
{
    public class EncriptadorCesar: Encriptador
    {
        private int iDesplazamiento;

        /// <summary>
        /// Crea un objeto de la clase EncriptadorCesar
        /// </summary>
        /// <param name="pNombre">Nombre del encriptador</param>
        /// <param name="pDesplazamiento">Desplazamiento del encriptador</param>
        public EncriptadorCesar(String pNombre, int pDesplazamiento):base (pNombre)
        {
            this.iDesplazamiento = pDesplazamiento;
        }

        /// <summary>
        /// Encripta una cadena de texto
        /// </summary>
        /// <param name="pCadena">Cadena a encriptar</param>
        /// <returns>Devuelve la cadena encriptada</returns>
        public override String Encriptar(String pCadena) {
            char[] cadena = pCadena.ToCharArray();
            String resultado = "";
            foreach (char letra in cadena)
            {
                resultado += (char)(iDesplazamiento + (int)letra);
            }
            return resultado;
        }

        /// <summary>
        /// Desencripta una cadena de texto
        /// </summary>
        /// <param name="pCadena">Cadena de texto a desencriptar</param>
        /// <returns>Devuelve el texto desencriptado</returns>
        public override String Desencriptar(String pCadena)
        {
            char[] cadena = pCadena.ToCharArray();
            String resultado = "";
            foreach (char letra in cadena)
            {
                resultado += (char)(-iDesplazamiento + (int)letra);
            }
            return resultado;
        }
    }
}
