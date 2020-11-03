using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4
{
    public class MenuTBinaria: Menu
    {
        /// <summary>
        /// Crea un objeto de la clase MenuTBinaria
        /// </summary>
        /// <param name="pNombre">Nombre del menu</param>
        public MenuTBinaria(String pNombre) : base(pNombre) { }

        /// <summary>
        /// Imprime en pantalla el menu
        /// </summary>
        public override void MostrarMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("||||||||              |||||||    ||||||||   |||   ||");
            Console.WriteLine("   ||                 ||    ||      ||      ||||  ||");
            Console.WriteLine("   ||      ||||||||   |||||||       ||      || || ||");
            Console.WriteLine("   ||                 ||    ||      ||      ||  ||||");
            Console.WriteLine("   ||                 |||||||    ||||||||   ||    ||");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("[1]Ingresar cadena   [2]Encriptar   [3]Desencriptar   [0]Volver");
        }

        /// <summary>
        /// Encripta una cadena de texto
        /// </summary>
        /// <param name="pCadena">Cadena a encriptar</param>
        /// <returns>Devuelve la cadena encriptada</returns>
        public override String Encriptar(String pCadena)
        {
            String cadena = iFabricaEncritadores.GetEncriptador("TBin").Encriptar(pCadena);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Cadena '{0}' encriptada: {1}", pCadena, cadena);
            Console.ReadKey();
            return cadena;
        }

        /// <summary>
        /// Desencripta una cadena de texto
        /// </summary>
        /// <param name="pCadena">Cadena a desencriptar</param>
        /// <returns>Devuelve la cadena desencriptada</returns>
        public override String Desencriptar(String pCadena)
        {
            String cadena = iFabricaEncritadores.GetEncriptador("TBin").Desencriptar(pCadena);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Cadena '{0}' desencriptada: {1}", pCadena, cadena);
            Console.ReadKey();
            return cadena;
        }
    }
}
