using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4
{
    public abstract class Menu: IMenu
    {
        protected FabricaEncriptadores iFabricaEncritadores = FabricaEncriptadores.Instancia;
        protected String iNombre;

        /// <summary>
        /// Crea un objeto de la clase Menu
        /// </summary>
        /// <param name="pNombre">Nombre del menu</param>
        public Menu(String pNombre)
        {
            this.iNombre = pNombre;
        }

        /// <summary>
        /// Solicita el ingreso de una opcion
        /// </summary>
        /// <returns>Devuelve un String</returns>
        public String PedirOpcion()
        {
            return Console.ReadLine();
        }

        /// <summary>
        /// Solicita un String, el cual sera la cadena a encriptar
        /// </summary>
        /// <returns>Devuelve un String</returns>
        public String PedirCadena()
        {
            Console.WriteLine("Ingrese la cadena a encriptar");
            return Console.ReadLine();
        }

        /// <summary>
        /// Imprime en pantalla el menu
        /// </summary>
        public abstract void MostrarMenu();

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
