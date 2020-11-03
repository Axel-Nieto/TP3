using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4
{
    public interface IMenu
    {
        /// <summary>
        /// Imprime en pantalla el menu
        /// </summary>
        public void MostrarMenu();
        public String PedirOpcion();
        public String PedirCadena();

        /// <summary>
        /// Encripta una cadena de texto
        /// </summary>
        /// <param name="pCadena">Cadena a encriptar</param>
        /// <returns>Devuelve la cadena encriptada</returns>
        public abstract String Encriptar(String pCadena);

        /// <summary>
        /// Desencripta una cadena de texto
        /// </summary>
        /// <param name="pCadena">Cadena a desencriptar</param>
        /// <returns>Devuelve la cadena desencriptada</returns>
        public abstract String Desencriptar(String pCadena);
    }
}
