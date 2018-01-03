using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cotizaciones.Models;
using Cotizaciones.Controllers;
using Cotizaciones.Data;
using Xunit;
using static Cotizaciones.Models.Persona;

namespace PersonaControllerTests
{
    public class CrearPersonaTest
    {
        private readonly CotizacionesContext _context;
        private PersonaController personaController;
        public CrearPersonaTest()
        {
            //_context = ???
            this.personaController = new PersonaController(_context);
        }
        
        [Fact]
        public async Task CreateAValidPersona()
        {
            int testId = 73;
            string testNombre = "Felipe";
            string testRut = "182345679";
            string testPaterno = "Rojas";
            string testMaterno = "Villaroel";
            string testEmail = "abc@ucn.cl";
            int testTelefono = 1234;
            Persona persona = new Persona(testId,testNombre,testRut,testPaterno,testMaterno,testEmail,testTelefono);
            var result = await personaController.Create(persona);
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnSession = Assert.IsType<Persona>(okResult.Value);
            Assert.NotNull(returnSession);
            Assert.Equal(73, persona.Id);
            Assert.Equal("Felipe", persona.Nombre);
            Assert.Equal("182345679", persona.Rut);
            Assert.Equal("Rojas", persona.Paterno);
            Assert.Equal("Villaroel", persona.Materno);
        }
    }
}