using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fachada fachada = new Fachada();
            int opcion1;
            int opcion2;
            do///BUCLE PARA EL MENU PRINCIPAL
            {
                Console.Clear();
                opcion1 = fachada.MenuPrincipal();
                switch (opcion1)
                {
                    case 1: //MENU PUNTOS
                        Console.Clear();
                        fachada.CrearPuntos();
                        do//Bucle menu secundario
                        {
                            Console.Clear();
                            opcion2 = fachada.MenuSecundarioPuntos();
                            switch (opcion2)
                            {
                                case 1: //Crear nuevos puntos
                                    Console.Clear();
                                    fachada.CrearPuntos();
                                    break;
                                case 2: //Calcular distancia entre dos puntos
                                    Console.Clear();
                                    fachada.CalcularDistanciaEntrePuntos();
                                    Console.ReadKey();
                                    break;
                                default:
                                    break;
                            }
                        } while (opcion2 != 0);
                        break;
                    case 2: //MENU CIRCULO
                        Console.Clear();
                        fachada.CrearCirculo();
                        do //Bucle menu secundario
                        {
                            Console.Clear();
                            opcion2 = fachada.MenuSecundarioCirculo();
                            switch (opcion2)
                            {
                                case 1: //Crear nuevo circulo
                                    Console.Clear();
                                    fachada.CrearCirculo();
                                    break;
                                case 2: //Calcular area
                                    Console.Clear();
                                    fachada.CalcularArea("circulo");
                                    Console.ReadKey();
                                    break;
                                case 3: //Calcular perimetro
                                    Console.Clear();
                                    fachada.CalcularPerimetro("circulo");
                                    Console.ReadKey();
                                    break;
                                case 4: //Calcular area y perimetro
                                    Console.Clear();
                                    fachada.CalcularArea("circulo");
                                    fachada.CalcularPerimetro("circulo");
                                    Console.ReadKey();
                                    break;
                                default:
                                    break;
                            }
                        } while (opcion2 != 0);
                        break;
                    case 3: //MENU TRIANGULO
                        Console.Clear();
                        fachada.CrearTriangulo();
                        do //Bucle menu secundario
                        {
                            Console.Clear();
                            opcion2 = fachada.MenuSecundarioTriangulo();
                            switch (opcion2)
                            {
                                case 1: //Crear nuevo triangulo
                                    Console.Clear();
                                    fachada.CrearTriangulo();
                                    break;
                                case 2: //Calcular area
                                    Console.Clear();
                                    fachada.CalcularArea("triangulo");
                                    Console.ReadKey();
                                    break;
                                case 3: //Calcular perimetro
                                    Console.Clear();
                                    fachada.CalcularPerimetro("triangulo");
                                    Console.ReadKey();
                                    break;
                                case 4: //Calcular area y perimetro
                                    Console.Clear();
                                    fachada.CalcularArea("triangulo");
                                    fachada.CalcularPerimetro("triangulo");
                                    Console.ReadKey();
                                    break;
                                default:
                                    break;
                            }
                        } while (opcion2 != 0);
                        break;
                    default:
                        break;
                }
            } while (opcion1 != 0);
        }
    }
}
