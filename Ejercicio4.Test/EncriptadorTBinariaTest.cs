using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Ejercicio4.Test
{
    public class EncriptadorTBinariaTest
    {
        [Fact]
        public void Test_EncriptadorTBinaria_Encriptar()
        {
            //Arrange
            var encriptador = new EncriptadorTBinaria("Null");
            var cadena = "Cadena";
            var resultadoEsperado = "aCedan";
            //Act
            var cadenaEncriptada = encriptador.Encriptar(cadena);
            //Assert
            Assert.Equal(resultadoEsperado, cadenaEncriptada);
        }

        [Fact]
        public void Test_EncriptadorNulo_Desencriptar()
        {
            //Arrange
            var encriptador = new EncriptadorTBinaria("Null");
            var cadena = "aCedan";
            var resultadoEsperado = "Cadena";
            //Act
            var cadenaEncriptada = encriptador.Encriptar(cadena);
            //Assert
            Assert.Equal(resultadoEsperado, cadenaEncriptada);
        }
    }
}
