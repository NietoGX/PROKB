
using Prokb.Data.Enums;
using Prokb.Data.Models.TiposFicha;

namespace Prokb.Data.Models
{

    public class FichaNoConformidadProductoAcabado : FichaNoConformidad
    {
        
        public EstadoProductoAcabado Estado { get; set; }
        public string FichaCalidadId { get; set; }
        public virtual FichaCalidad FichaCalidad { get; set; }
        
        public string FichaPlanificacionId { get; set; }
        public virtual FichaPlanificacion FichaPlanificacion { get; set; }
        
        public string FichaLogisticaId { get; set; }
        public virtual FichaLogistica FichaLogistica { get; set; }
        
        public string FichaArticuloId { get; set; }
        public virtual FichaArticulo FichaArticulo { get; set; }
        
        public string FichaIncidenciaId { get; set; }
        public virtual FichaIncidencia FichaIncidencia { get; set; }
    }
}
