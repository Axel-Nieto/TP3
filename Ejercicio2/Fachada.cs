using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Ejercicio2
{
    public class Fachada
    {
        private FachadaImp iFachadaImp;

        /// <summary>
        /// Instancia de la fachada del programa
        /// </summary>
        public Fachada()
        {
            this.iFachadaImp = new FachadaImp();
        }

        /// <summary>
        /// Imprime el menu principal y solicita el ingreso de una opcion
        /// </summary>
        /// <returns>Devuelve un entero</returns>
        public int MenuPrincipal()
        {
            return iFachadaImp.MenuPrincipal();
        }

        /// <summary>
        /// Imprime el menu de operaciones con puntos
        /// </summary>
        /// <returns>Devuelve un entero</returns>
        public int MenuSecundarioPuntos()
        {
            return iFachadaImp.MenuSecundarioPuntos();
        }

        /// <summary>
        /// Imprime el menu de operaciones con un circulo
        /// </summary>
        /// <returns>Devuelve un entero</returns>
        public int MenuSecundarioCirculo()
        {
            return iFachadaImp.MenuSecundarioCirculo();
        }

        /// <summary>
        /// Imprime el menu de operaciones con un triangulo
        /// </summary>
        /// <returns>Devuelve un entero</returns>
        public int MenuSecundarioTriangulo()
        {
            return iFachadaImp.MenuSecundarioTriangulo();
        }

        /// <summary>
        /// Crea dos puntos
        /// </summary>
        public void CrearPuntos()
        {
            iFachadaImp.CrearPuntos();
        }

        /// <summary>
        /// Crea un Circulo
        /// </summary>
        public void CrearCirculo()
        {
            iFachadaImp.CrearCirculo();
        }

        /// <summary>
        /// Crea un Triangulo
        /// </summary>
        public void CrearTriangulo()
        {
            iFachadaImp.CrearTriangulo();
        }

        /// <summary>
        /// Calcula y muestra la distancia entre dos puntos ya establecidos
        /// </summary>
        public void CalcularDistanciaEntrePuntos()
        {
            iFachadaImp.CalcularDistanciaEntrePuntos();
        }

        /// <summary>
        /// Calcula el area de una figura geometrica
        /// </summary>
        /// <param name="pFigura">Nombre de la figura</param>
        public void CalcularArea(String pFigura)
        {
            iFachadaImp.CalcularArea(pFigura);
        }

        /// <summary>
        /// Calcula el perimetro de una figura geometrica
        /// </summary>
        /// <param name="pFigura">Nombre de la figura</param>
        public void CalcularPerimetro(String pFigura)
        {
            iFachadaImp.CalcularPerimetro(pFigura);
        }
    }
}
