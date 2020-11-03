using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Ejercicio4.Test
{
    public class EncriptadorCesarTest
    {
        [Fact]
        public void Test_EncriptadorCesar_Encriptar()
        {
            //Arrange
            var encriptador = new EncriptadorCesar("Cesar",2);
            var cadena = "Cadena";
            var resultadoEsperado = "Ecfgpc";
            //Act
            var cadenaEncriptada = encriptador.Encriptar(cadena);
            //Assert
            Assert.Equal(resultadoEsperado, cadenaEncriptada);
        }

        [Fact]
        public void Test_EncriptadorCesar_Desencriptar()
        {
            var encriptador = new EncriptadorCesar("Cesar", 2);
            var cadena = "Ecfgpc";
            var resultadoEsperado = "Cadena";
            //Act
            var cadenaEncriptada = encriptador.Desencriptar(cadena);
            //Assert
            Assert.Equal(resultadoEsperado, cadenaEncriptada);
        }
    }
}
