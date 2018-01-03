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

    public Persona(){
        this.Id = 0;
        this.Rut = "";
        this.Nombre = "";
        this.Paterno = "";
        this.Materno = "";
    }
    public Persona(int Id,string Rut,string Nombre,string Paterno,string Materno){
        this.Id = Id;
        this.Rut = Rut;
        this.Nombre = Nombre;
        this.Paterno = Paterno;
        this.Materno = Materno;
    }

    }
}