
using Prokb.Data.DataDTO.Enums;
using Prokb.Data.DataDTO.TiposFicha;
using System.ComponentModel.DataAnnotations;

namespace Prokb.Data.DataDTO.MedioAmbiente
{
    
    class FichaNoConformidadProductoAcabadoDTO : FichaNoConformicadDTO
    {
        
        public EstadoProductoAcabadoDTO Estado { get; set; }
        public string FichaCalidadId { get; set; }
        public string FichaPlanificacionId { get; set; }
        public string FichaLogisticaId { get; set; }    
        public string FichaArticuloId { get; set; }
        public string FichaIncidenciaId { get; set; }

    }
}
