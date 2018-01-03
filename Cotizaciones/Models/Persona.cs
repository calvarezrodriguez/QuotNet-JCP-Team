using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
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
    public string Email {get; set; }
    public int Telefono {get; set; }
    public Persona(){
        this.Id = 0;
        this.Rut = "";
        this.Nombre = "";
        this.Paterno = "";
        this.Materno = "";
        this.Email = "";
        this.Telefono = 0;
    }
    public Persona(int Id,string Rut,string Nombre,string Paterno,string Materno,string email,int telefono){
        if(validarRut(Rut)){
            this.Rut = Rut;
        }else{
            throw new Exception("El Rut ingresado no es valido");
        }
        this.Id = Id;
        this.Nombre = Nombre;
        this.Paterno = Paterno;
        this.Materno = Materno;
        this.Email = email;
        this.Telefono = telefono;
    }
    public bool validarRut(string rut){
        bool validacion = false;
        try {
            rut =  rut.ToUpper();
            rut = rut.Replace(".", "");
            rut = rut.Replace("-", "");
            int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));
            char dv = char.Parse(rut.Substring(rut.Length - 1, 1));
            int m = 0, s = 1;
            for (; rutAux != 0; rutAux /= 10) {
                s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
            }
            if (dv == (char) (s != 0 ? s + 47 : 75)) {
                validacion = true;
            }
        }catch (Exception) {
            return false;
        }
        return validacion;
        }
    }
}