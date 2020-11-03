using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4
{
    public class FabricaEncriptadores
    {
        private static readonly Lazy<FabricaEncriptadores> cInstancia = new Lazy<FabricaEncriptadores>(new FabricaEncriptadores());
        private IDictionary<String, IEncriptador> iEncriptadores;

        /// <summary>
        /// Crea un Objeto de la Clase FabricaEncriptadores
        /// </summary>
        private FabricaEncriptadores() {
            this.iEncriptadores = new Dictionary<String, IEncriptador>();
            this.iEncriptadores.Add("AES", new EncriptadorAES("AES"));
            this.iEncriptadores.Add("Cesar", new EncriptadorCesar("Cesar",9));
            this.iEncriptadores.Add("Inv", new EncriptadorInversa("Inv"));
            this.iEncriptadores.Add("Null", new EncriptadorNulo("Null"));
            this.iEncriptadores.Add("TBin", new EncriptadorTBinaria("TBin"));
        }

        /// <summary>
        /// Devuelve el objeto instanciado
        /// </summary>
        public static FabricaEncriptadores Instancia { get { return cInstancia.Value; } }

        /// <summary>
        /// Devuelve uno de los encriptadores de la fabrica, usando como criterio de busqueda su
        /// nombre en codigo.
        /// </summary>
        /// <param name="nombre">Clave del encriptador en el diccionario</param>
        /// <returns>Devuelve un objeto que puede hacer uso de la interfaz IEncriptador</returns>
        public IEncriptador GetEncriptador(String nombre)
        {
            if (iEncriptadores.ContainsKey(nombre))
            {
                return iEncriptadores[nombre];
            }
            else
            {
                return iEncriptadores["Null"]; //Si el nombre es incorrecto devolvera un EncriptadorNulo
            }           
        }
    }
}
