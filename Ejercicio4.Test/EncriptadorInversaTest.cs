using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Ejercicio4.Test
{
    public class EncriptadorInversaTest
    {
        [Fact]
        public void Test_EncriptadorInversa_Encriptar()
        {
            //Arrange
            var encriptador = new EncriptadorInversa("Inv");
            var cadena = "Cadena";
            var resultadoEsperado = "anedaC";
            //Act
            var cadenaEncriptada = encriptador.Encriptar(cadena);
            //Assert
            Assert.Equal(resultadoEsperado, cadenaEncriptada);
        }

        [Fact]
        public void Test_EncriptadorInversa_Desencriptar()
        {
            //Arrange
            var encriptador = new EncriptadorInversa("Inv");
            var cadena = "anedaC";
            var resultadoEsperado = "Cadena";
            //Act
            var cadenaEncriptada = encriptador.Encriptar(cadena);
            //Assert
            Assert.Equal(resultadoEsperado, cadenaEncriptada);
        }
    }
}
