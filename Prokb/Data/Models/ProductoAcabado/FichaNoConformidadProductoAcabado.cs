
using Prokb.Data.Enums;
using Prokb.Data.Models.TiposFicha;

namespace Prokb.Data.Models
{

    public class FichaNoConformidadProductoAcabado : FichaNoConformidad
    {
        
        public EstadoProductoAcabado Estado { get; set; }
        public string FichaCalidadId { get; set; }
        public FichaCalidad FichaCalidad { get; set; }
        
        public string FichaPlanificacionId { get; set; }
        public FichaPlanificacion FichaPlanificacion { get; set; }
        
        public string FichaLogisticaId { get; set; }
        public FichaLogistica FichaLogistica { get; set; }
        
        public string FichaArticuloId { get; set; }
        public FichaArticulo FichaArticulo { get; set; }
        
        public string FichaIncidenciaId { get; set; }
        public FichaIncidencia FichaIncidencia { get; set; }
    }
}
