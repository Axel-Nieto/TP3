using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4
{
    public class FabricaMenu
    {
        private static readonly Lazy<FabricaMenu> cInstancia = new Lazy<FabricaMenu>(new FabricaMenu());
        private IDictionary<String, IMenu> iMenues;

        /// <summary>
        /// Crea un objeto de la clase FabricaMenu
        /// </summary>
        private FabricaMenu()
        {
            this.iMenues = new Dictionary<String, IMenu>();
            iMenues.Add("0", new MenuPrincipal("0"));
            iMenues.Add("Cesar", new MenuCesar("Cesar"));
            iMenues.Add("AES", new MenuAES("AES"));
            iMenues.Add("Inv", new MenuInversa("Inv"));
            iMenues.Add("Null", new MenuNulo("Null"));
            iMenues.Add("TBin", new MenuTBinaria("TBin"));
        }

        /// <summary>
        /// Devuelve el objeto instanciado
        /// </summary>
        public static FabricaMenu Instancia { get { return cInstancia.Value; } }

        /// <summary>
        /// Devuelve uno de los menus de la fabrica, usando como criterio de busqueda su
        /// nombre en codigo.
        /// </summary>
        /// <param name="pNombre">Clave del menu en el diccionario</param>
        /// <returns>Devuelve un objeto que puede hacer uso de la interfaz IMenu</returns>
        public IMenu GetMenu(String pNombre)
        {
            if (iMenues.ContainsKey(pNombre))
            {
                return iMenues[pNombre];
            }
            else return iMenues["Null"]; //Si el nombre es incorrecto, devolvera un MenuNulo           
        }
    }
}
