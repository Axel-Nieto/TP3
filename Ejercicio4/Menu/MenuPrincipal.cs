using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4
{
    public class MenuPrincipal:Menu
    {
        /// <summary>
        /// Crea un objeto de la clase MenuPrincipal
        /// </summary>
        /// <param name="pNombre">Nombre del menu</param>
        public MenuPrincipal(String pNombre) : base(pNombre) { }

        /// <summary>
        /// Imprime en pantalla el menu
        /// </summary>
        public override void MostrarMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("||||||||   ||||||||   ||    ||   ||||||||   ||||||||   ||||||||");
            Console.WriteLine("||         ||   ||     ||  ||    ||    ||      ||      ||    ||");
            Console.WriteLine("||         ||||||       ||||     ||||||||      ||      ||    ||");
            Console.WriteLine("||         ||   ||       ||      ||            ||      ||    ||");
            Console.WriteLine("||||||||   ||    ||      ||      ||            ||      ||||||||");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                    Axel Nieto. UTN FRCU 2020");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Encriptadores disponibles (Si no escribe ninguno valido se ejecutara el Encriptador 'Null'):");
            Console.WriteLine("");
            Console.WriteLine("AES");
            Console.WriteLine("Cesar");
            Console.WriteLine("Inv (Transposicion inversa");
            Console.WriteLine("TBin (Transposicion Binaria)");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine("Ingrese el nombre del encriptador o [s]Salir, y luego presione [Enter]");
        }

        /// <summary>
        /// Encripta una cadena de texto
        /// </summary>
        /// <param name="pCadena">Cadena a encriptar</param>
        /// <returns>Devuelve la cadena encriptada</returns>
        public override String Encriptar(String pCadena)
        {
            return null;
        }

        /// <summary>
        /// Desencripta una cadena de texto
        /// </summary>
        /// <param name="pCadena">Cadena a desencriptar</param>
        /// <returns>Devuelve la cadena desencriptada</returns>
        public override String Desencriptar(String pCadena)
        {
            return null;
        }
    }
}
