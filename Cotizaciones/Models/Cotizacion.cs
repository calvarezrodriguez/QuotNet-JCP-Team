using System.ComponentModel.DataAnnotations;
/// <sumary>
/// Archivo donde se definen las clases 
/// </sumary>
/// 
namespace Cotizaciones.Models {

/// <sumary>
/// Clase que representa a una persona en el Sistema
/// </sumary>
/// <remarks>
/// Esta clase pertenece al modelo del Dominio y posee las siguientes restricciones:
/// - No permite valores null en sus atributos.
/// </remarks>
public class Cotizacion{
    [Key]
    public int correlativoID {get;set;}    
    public string tipoServicio {get;set;}
    public string descripcion {get;set;}
    public int montoTotal {get;set;}
    public int valorAgregado {get;set;}
    public string fecha {get;set;}
    public string estado {get;set;}
    public int version {get;set;}
}
}