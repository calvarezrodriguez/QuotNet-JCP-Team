using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using Cotizaciones.Models;
using Xunit;

namespace Tests
{
    
    public class testValidarRut
    {
        [Theory]
        [InlineData("abc")]
        [InlineData("a1b2c3")]
        [InlineData("a*s+d")]
        [InlineData("1*2]3@a")]
        public void ValidarRutDiscriminaLetrasYSimbolos(string testRut){
            Persona persona = new Persona();
            var result = persona.validarRut(testRut);
            Assert.False(result, $"{testRut} no debe ser valido");
        }

        [Theory]
        [InlineData("123")]
        [InlineData("12345678")]
        [InlineData("21354687")]
        public void ValidarRutRechazaNumerosInvalidos(string testRut){
            Persona persona = new Persona();
            var result = persona.validarRut(testRut);
            Assert.False(result, $"{testRut} no debe ser valido, digito verificador incorrecto");
        }

        [Theory]
        [InlineData("188974732")]
        [InlineData("187930472")]
        public void ValidarRutAceptaNumerosInvalidos(string testRut){
            Persona persona = new Persona();
            var result = persona.validarRut(testRut);
            Assert.True(result, $"{testRut} debe ser valido");
        }
    }
}