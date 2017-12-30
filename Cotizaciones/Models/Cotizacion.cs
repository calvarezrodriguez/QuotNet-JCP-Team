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
public class Cotizacion{

    public int correlativo {get;set;}
    public int tipoServicio {get;set;}
    public int descripcion {get;set;}
    public int montoTotal {get;set;}
    public int valorAgregado {get;set;}
    public int fecha {get;set;}
    public int estado {get;set;}
    public int version {get;set;}
}
}