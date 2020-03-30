using Prokb.Data.Enums;
using Prokb.Data.Models.TiposFicha;
using Prokb.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace Prokb.Data.Models
{
    public class FichaNoConformidadEficienciaEnergetica : FichaNoConformidad
    {
        
        public EstadoEME Estado { get; set; }   
        public string FichaNoConformidadId { get; set; }
        
        public FichaAnalisis FichaAnalisis { get; set; }
        public string FichaAnalisisId { get; set; }
        public FichaEjecucion FichaEjecucion { get; set; }
        public string FichaEjecucionId { get; set; }
        public FichaArticuloEFIMED FichaArticuloEFIMED { get; set; }
        public string FichaArticuloEFIMEDId { get; set; }
        public FichaIncidencia FichaIncidencia { get; set; }
        public string FichaIncidenciaId { get; set; }
       
    }
}
