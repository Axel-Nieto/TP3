using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio2
{
    public class FachadaImp
    {
        private Punto iPunto1;
        private Punto iPunto2;
        private Punto iPunto3;
        private FiguraGeometrica iTriangulo;
        private FiguraGeometrica iCirculo;

        /// <summary>
        /// Crea un objeto de tipo FachadaImp (Implementacion de la fachada)
        /// </summary>
        public FachadaImp()
        {
            this.iPunto1 = new Punto();
            this.iPunto2 = new Punto();
            this.iPunto3 = new Punto();
            this.iTriangulo = new Triangulo(iPunto1,iPunto2,iPunto3);
            this.iCirculo = new Circulo(0,0,0);
        }

        /// <summary>
        /// Imprime en pantalla el menu principal
        /// </summary>
        /// <returns>
        /// Regresa el numero de opcion ingresado
        /// </returns>
        public int MenuPrincipal()
        {
            Console.WriteLine("PROGRAMA  DEL  TP1:  EJERCICIO  1");
            Console.WriteLine("");
            Console.WriteLine("MENU PRINCIPAL");
            Console.WriteLine("");
            Console.WriteLine("Seleccione una opcion");
            Console.WriteLine("1.Dos puntos");
            Console.WriteLine("2.Circulo");
            Console.WriteLine("3.Triangulo");
            Console.WriteLine("");
            Console.WriteLine("0.Salir");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }

        /// <summary>
        /// Imprime en pantalla el menu para operar con puntos
        /// </summary>
        /// <returns>
        /// Regresa el numero de opcion ingresado
        /// </returns>
        public int MenuSecundarioPuntos()
        {
            Console.WriteLine("PROGRAMA  DEL  TP1:  EJERCICIO  1");
            Console.WriteLine("");
            Console.WriteLine("Seleccione una opcion:");
            Console.WriteLine("");
            Console.WriteLine("1.Definir puntos");
            Console.WriteLine("2.Calcular distancia entre dos puntos");
            Console.WriteLine("");
            Console.WriteLine("0.Volver");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }

        /// <summary>
        /// Imprime en pantalla el menu para operar con circulos
        /// </summary>
        /// <returns>
        /// Regresa el numero de opcion ingresado
        /// </returns>
        public int MenuSecundarioCirculo()
        {
            Console.WriteLine("PROGRAMA  DEL  TP1:  EJERCICIO  1");
            Console.WriteLine("");
            Console.WriteLine("Seleccione una opcion:");
            Console.WriteLine("");
            Console.WriteLine("1.Definir circulo");
            Console.WriteLine("2.Calcular area del circulo");
            Console.WriteLine("3.Calcular perimetro del circulo");
            Console.WriteLine("4.Calcular area y perimetro del circulo");
            Console.WriteLine("");
            Console.WriteLine("0.Volver");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }

        /// <summary>
        /// Imprime en pantalla el menu para operar con triangulos
        /// </summary>
        /// <returns>
        /// Regresa el numero de opcion ingresado
        /// </returns>
        public int MenuSecundarioTriangulo()
        {
            Console.WriteLine("PROGRAMA  DEL  TP1:  EJERCICIO  1");
            Console.WriteLine("");
            Console.WriteLine("Seleccione una opcion:");
            Console.WriteLine("");
            Console.WriteLine("1.Definir triangulo");
            Console.WriteLine("2.Calcular area del triangulo");
            Console.WriteLine("3.Calcular perimetro del triangulo");
            Console.WriteLine("4.Calcular area y perimetro del triangulo");
            Console.WriteLine("");
            Console.WriteLine("0.Volver");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }

        /// <summary>
        /// Ingresa el valor del componente X en una n-Tupla
        /// </summary>
        /// <returns>Devuelve un 'double'</returns>
        public double PedirComponenteX()
        {
            Console.Write("X: ");
            return (Convert.ToDouble(Console.ReadLine()));
        }

        /// <summary>
        /// Ingresa el valor del componente Y en una n-Tupla
        /// </summary>
        /// <returns>Devuelve un 'double'</returns>
        public double PedirComponenteY()
        {
            Console.Write("Y: ");
            return (Convert.ToDouble(Console.ReadLine()));
        }

        /// <summary>
        /// Ingresa el valor del radio de una circunferencia
        /// </summary>
        /// <returns>Devuelve un 'double'</returns>
        public double PedirRadio()
        {
            Console.Write("Radio de la circunferencia: ");
            return (Convert.ToDouble(Console.ReadLine()));
        }

        /// <summary>
        /// Crea un objeto de la clase Punto
        /// </summary>
        /// <returns>Devuelve un Punto</returns>
        public Punto CrearPunto()
        {
            Console.WriteLine("Coordenadas del punto");
            double puntoX = this.PedirComponenteX();
            double puntoY = this.PedirComponenteY();
            Punto punto = new Punto(puntoX, puntoY); //Crea un punto a partir de las coordenadas pedidas
            return punto;
        }

        /// <summary>
        /// Crea dos objetos Punto y los almacena en el objeto FachadaImp
        /// </summary>
        public void CrearPuntos()
        {
            Console.WriteLine("Punto 1");
            this.iPunto1 = CrearPunto();
            Console.WriteLine("");
            Console.WriteLine("Punto 2");
            this.iPunto2 = CrearPunto();
        }

        /// <summary>
        /// Crea un Circulo y lo almacena en el objeto FachadaImp
        /// </summary>
        public void CrearCirculo()
        {
            Console.WriteLine("Coordenadas del centro");
            double centroX = this.PedirComponenteX();
            double centroY = this.PedirComponenteY();
            double radio = this.PedirRadio();
            Console.WriteLine("");
            this.iCirculo = new Circulo(centroX, centroY, radio); //Crea un circulo a partir de las coordenadas y el radio
        }

        /// <summary>
        /// Crea un Triangulo y lo almacena en el objeto FachadaImp
        /// </summary>
        public void CrearTriangulo()
        {
            Console.WriteLine("Coordenadas del primer punto");
            double punto1X = this.PedirComponenteX();
            double punto1Y = this.PedirComponenteY();
            Punto pPunto1 = new Punto(punto1X, punto1Y);
            Console.WriteLine("Coordenadas del segundo punto");
            double punto2X = this.PedirComponenteX();
            double punto2Y = this.PedirComponenteY();
            Punto pPunto2 = new Punto(punto2X, punto2Y);
            Console.WriteLine("Coordenadas del tercer punto");
            double punto3X = this.PedirComponenteX();
            double punto3Y = this.PedirComponenteY();
            Punto pPunto3 = new Punto(punto3X, punto3Y);
            this.iTriangulo = new Triangulo(pPunto1, pPunto2, pPunto3); //Crea un triangulo a partir de los tres puntos
        }

        /// <summary>
        /// Calcula y muestra la distancia entre dos puntos
        /// </summary>
        public void CalcularDistanciaEntrePuntos()
        {
            Console.WriteLine("La distancia entre los puntos es: " + iPunto1.CalcularDistanciaDesde(iPunto2));
        }

        /// <summary>
        /// Calcula y muestra el area de una figura geometrica
        /// </summary>
        /// <param name="pFigura">Nombre de la figura geometrica</param>
        public void CalcularArea(String pFigura)
        {
            switch (pFigura)
            {
                case "circulo":
                    Console.WriteLine("El area del circulo es: " + iCirculo.CalcularArea());
                    break;
                case "triangulo":
                    Console.WriteLine("El area del triangulo es: " + iTriangulo.CalcularArea());
                    break;
                default:
                    Console.WriteLine("Error: no existe la figura o campo vacio");
                    break;
            }           
        }

        /// <summary>
        /// Calcula y muestra el perimetro de una figura geometrica
        /// </summary>
        /// <param name="pFigura">Nombre de la figura geometrica</param>
        public void CalcularPerimetro(String pFigura)
        {
            switch (pFigura)
            {
                case "circulo":
                    Console.WriteLine("El perimetro del circulo es: " + iCirculo.CalcularPerimetro());
                    break;
                case "triangulo":
                    Console.WriteLine("El perimetro del triangulo es: " + iTriangulo.CalcularPerimetro());
                    break;
                default:
                    Console.WriteLine("Error: no existe la figura o campo vacio");
                    break;
            }
        }
    }
}
