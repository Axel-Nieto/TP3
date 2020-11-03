using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Este programa no posee fachada, ya que para realizar el ejercicio no se considera necesaria

            Veterinaria veterinaria = new Veterinaria();
            Animal[] animales = new Animal[0];
            Animal[] aux = animales; //Arreglo auxiliar para almacenar el contenido de 'animales' cuando haya que incrementar el tamaño de este
            Animal perro = new Perro();
            Animal gato = new Gato();
            int opcion;
            do //Bucle para ingresar continuamente animales al array
            {
                Console.WriteLine("Agregar perro (1) o gato(2). Cualquier otra tecla para salir");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        aux = animales;
                        animales = new Animal[animales.Length + 1];
                        aux.CopyTo(animales, 0);
                        animales[animales.Length - 1] = perro;
                        break;
                    case 2:
                        aux = animales;
                        animales = new Animal[animales.Length + 1];
                        aux.CopyTo(animales, 0);
                        animales[animales.Length - 1] = gato;
                        break;
                    default:
                        opcion = 0;
                        break;
                }
                Console.WriteLine("");
            } while (opcion != 0);
            veterinaria.AceptarAnimales(animales);
            Console.ReadKey();
        }
    }
}
