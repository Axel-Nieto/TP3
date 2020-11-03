using Ejercicio3;
using System;

namespace Ejercicio3
{
    public class Program
    {
        static void Main(string[] args)
        {
            RepositorioPacientes repositorioPacientes = new RepositorioPacientes();
            Fachada fachada = new Fachada(repositorioPacientes);
            int opcion;
            int opcion2;
            do
            {
                opcion = fachada.MenuPrincipal();
                switch (opcion)
                {
                    case 1:
                        opcion2 = fachada.MenuSalaConsultas();
                        switch (opcion2)
                        {
                            case 1:
                                fachada.AtenderPacienteConsulta();
                                Console.ReadKey();
                                break;
                            case 2:
                                fachada.OtorgarTurnoConsulta();
                                Console.ReadKey();
                                break;
                            case 3:
                                fachada.MostrarPacientesConsultas();
                                Console.ReadKey();
                                break;
                            default:
                                opcion2 = 0;
                                break;
                        }
                        break;
                    case 2:
                        opcion2 = fachada.MenuSalaUrgencias();
                        switch (opcion2)
                        {
                            case 1:
                                fachada.AtenderPacienteUrgencia();
                                Console.ReadKey();
                                break;
                            case 2:
                                fachada.OtorgarTurnoUrgencia();
                                Console.ReadKey();
                                break;
                            case 3:
                                fachada.MostrarPacientesUrgencias();
                                Console.ReadKey();
                                break;
                            default:
                                opcion2 = 0;
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }while (opcion != 0) ;
        }
    }
}
