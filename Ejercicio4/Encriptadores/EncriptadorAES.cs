using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Ejercicio4
{
    public class EncriptadorAES:Encriptador
    {
        private static String iClaveDePrueba = "clavedeprueba123"; //Clave para probar el encriptador

        /// <summary>
        /// Crea un objeto de la clase EncriptadorAES
        /// </summary>
        /// <param name="pNombre">Nombre del encriptador</param>
        public EncriptadorAES(String pNombre): base(pNombre) { 
        }

        /// <summary>
        /// Genera un proveedor Rijndael utilizando una clave y definiendo el tamaño del vector de inicializacion
        /// </summary>
        /// <returns>Devuelve el proveedor Rijndael</returns>
        private static RijndaelManaged GetInstance()
        {
            RijndaelManaged proveedor = new RijndaelManaged();
            proveedor.Key = Encoding.Unicode.GetBytes(iClaveDePrueba);
            proveedor.IV = new byte[proveedor.BlockSize / 8];
            return proveedor;
        }

        /// <summary>
        /// Encripta una cadena de texto
        /// </summary>
        /// <param name="pCadena">Cadena a encriptar</param>
        /// <returns>Devuelve la cadena encriptada</returns>
        public override string Encriptar(string pCadena)
        {           
            RijndaelManaged proveedor = GetInstance();                   
            ICryptoTransform objCrypto = proveedor.CreateEncryptor();
            byte[] arrayBuffer = Encoding.Unicode.GetBytes(pCadena); 
            return Convert.ToBase64String(objCrypto.TransformFinalBlock(arrayBuffer,0,arrayBuffer.Length));
        }

        /// <summary>
        /// Desencripta una cadena de texto
        /// </summary>
        /// <param name="pCadena">Cadena a desencriptar</param>
        /// <returns>Devuelve la cadena desencriptada</returns>
        public override string Desencriptar(string pCadena)
        {
            byte[] arrayBuffer = Convert.FromBase64String(pCadena);
            RijndaelManaged proveedor = GetInstance();
            ICryptoTransform objCrypto = proveedor.CreateDecryptor();
            return Encoding.Unicode.GetString(objCrypto.TransformFinalBlock(arrayBuffer, 0, arrayBuffer.Length));
        }
    }
}
