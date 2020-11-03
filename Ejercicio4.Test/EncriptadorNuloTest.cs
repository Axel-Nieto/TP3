using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Ejercicio4.Test
{
    public class EncriptadorNuloTest
    {
        [Fact]
        public void Test_EncriptadorNulo_Encriptar()
        {
            //Arrange
            var encriptador = new EncriptadorNulo("Null");
            var cadena = "Cadena";
            var resultadoEsperado = "Cadena";
            //Act
            var cadenaEncriptada = encriptador.Encriptar(cadena);
            //Assert
            Assert.Equal(resultadoEsperado, cadenaEncriptada);
        }

        [Fact]
        public void Test_EncriptadorNulo_Desencriptar()
        {
            //Arrange
            var encriptador = new EncriptadorNulo("Null");
            var cadena = "Cadena";
            var resultadoEsperado = "Cadena";
            //Act
            var cadenaEncriptada = encriptador.Encriptar(cadena);
            //Assert
            Assert.Equal(resultadoEsperado, cadenaEncriptada);
        }
    }
}
