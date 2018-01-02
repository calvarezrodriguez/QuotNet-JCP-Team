using System.ComponentModel.DataAnnotations;
/// <sumary>
/// Archivo donde se definen las clases 
/// </sumary>
/// 
namespace Cotizaciones.Models {

/// <sumary>
/// Clase que representa la relacion de una persona con su cotizacion en el Sistema
/// </sumary>
/// <remarks>
/// Esta clase pertenece al modelo del Dominio y posee las siguientes restricciones:
/// - No permite valores null en sus atributos.
/// </remarks>
public class CotizacionPersona{
    [Key]
    public int CotizacionPersonaID {get;set;}    
/// llaves foraneas
    public Persona persona {get; set; }
    public Cotizacion cotizacion {get; set; }
}
}