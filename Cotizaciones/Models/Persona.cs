using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
/// <sumary>
/// Archivo donde se definen las clases 
/// </sumary>
namespace Cotizaciones.Models {

/// <sumary>
/// Clase que representa a una persona en el Sistema
/// </sumary>
/// <remarks>
/// Esta clase pertenece al modelo del Dominio y posee las siguientes restricciones:
/// - No permite valores null en sus atributos.
/// </remarks>
public class Persona{
    public int Id {get; set; }
    public string Rut {get; set; }
    public string Nombre {get; set; }
    public string Paterno {get; set; }    
    public string Materno {get; set; }

     public List<CotizacionPersona> CotizacionPersona { get; set; }

    }
}