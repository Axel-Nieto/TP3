using System;
using Xunit;

namespace Ejercicio4.Test
{
    public class EncriptadorAESTest
    {
        [Fact]
        public void Test_EncriptadorAES_Encriptar()
        {
            //Arrange
            var encriptador = new EncriptadorAES("AES");
            var cadena = "Cadena";
            var resultadoEsperado = "jEn1/Pf70iskHv6Me+LNuA==";
            //Act
            var cadenaEncriptada = encriptador.Encriptar(cadena);
            //Assert
            Assert.Equal(resultadoEsperado, cadenaEncriptada);
        }

        [Fact]
        public void Test_EncriptadorAES_Desencriptar()
        {
            //Arrange
            var encriptador = new EncriptadorAES("AES");
            var cadena = "jEn1/Pf70iskHv6Me+LNuA==";
            var resultadoEsperado = "Cadena";
            //Act
            var cadenaDesencriptada = encriptador.Desencriptar(cadena);
            //Assert
            Assert.Equal(resultadoEsperado, cadenaDesencriptada);
        }
    }
}
