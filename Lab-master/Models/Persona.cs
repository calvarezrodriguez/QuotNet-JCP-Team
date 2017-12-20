using System;

/// <summary>
/// Archivo donde se definen las clases del Dominio del problema.
/// </summary>
namespace Lab.Models
{

    /// <summary>
    /// Clase que representa a una persona en el Sistema.
    /// </summary>
    /// <remarks>
    /// Esta clase pertenece al modelo del Dominio y posee las siguientes restricciones:
    /// - No permite valores null en sus atributos.
    /// </remarks>
    public class Persona
    {
        public int ID { get; set; }

        public string Rut { get; set; }

        public string Nombre { get; set; }

        public string Paterno { get; set; }

        public string Materno { get; set; }    
    }
}