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
    public int[] CotizacionesAdjuntas {get; set; }
    public Persona(){
        int[] cotizacionesAdjuntas = new int[99];
        for(int i = 0;i<99;i++){
            cotizacionesAdjuntas[i] = 0;
        }
        this.CotizacionesAdjuntas = CotizacionesAdjuntas;
    }
    public void addCotizacion(int correlativo){
        for(int i = 0;i<99;i++){
            if(this.CotizacionesAdjuntas[i] == 0){
                this.CotizacionesAdjuntas[i] = correlativo;
                break;
            }
        }
    }
    public void eliminarCotizacion(int correlativo){
        int pos = this.buscarCotizacion(correlativo);
        if(pos!=-1){
            for(int i = pos;i<98;i++){
                this.CotizacionesAdjuntas[i] = this.CotizacionesAdjuntas[i+1];
            }
            this.CotizacionesAdjuntas[99]=0;
        }
    }
    public int buscarCotizacion(int correlativo){
        for(int i = 0;i<99;i++){
            if(this.CotizacionesAdjuntas[i] == correlativo){
                return i;
            }
        }
        return -1;
    }
    }
}