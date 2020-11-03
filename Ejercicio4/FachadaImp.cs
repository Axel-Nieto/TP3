using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4
{
    public class FachadaImp
    {
        FabricaEncriptadores iFabricaEncriptadores;
        FabricaMenu iFabricaMenu;

        public FachadaImp()
        {
            iFabricaEncriptadores = FabricaEncriptadores.Instancia;
            iFabricaMenu = FabricaMenu.Instancia;
        }

        /// <summary>
        /// Arranque del programa a traves del menu principal
        /// </summary>
        public void MenuPrincipal()
        {
            String opcion;
            do
            {
                iFabricaMenu.GetMenu("0").MostrarMenu();
                opcion = Console.ReadLine();
                if(opcion != "s") MenuEncriptador(opcion);
            } while (opcion != "s");       
        }

        /// <summary>
        /// Inicia el menu de un encriptador, determinado por el codigo del mismo
        /// </summary>
        /// <param name="pOpcion">Codigo de menu del encriptador</param>
        public void MenuEncriptador(String pOpcion)
        {
            String opcion;
            String cadena = "";
            do
            {
                iFabricaMenu.GetMenu(pOpcion).MostrarMenu();
                opcion = iFabricaMenu.GetMenu(pOpcion).PedirOpcion();
                switch (opcion)
                {
                    case "1":
                        cadena = iFabricaMenu.GetMenu(pOpcion).PedirCadena();
                        break;
                    case "2":
                        cadena = iFabricaMenu.GetMenu(pOpcion).Encriptar(cadena);
                        break;
                    case "3":
                        cadena = iFabricaMenu.GetMenu(pOpcion).Desencriptar(cadena);
                        break;
                    default:
                        break;
                }
            } while (opcion != "0");
        }
    }
}
