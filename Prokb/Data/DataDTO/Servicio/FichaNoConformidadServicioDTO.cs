using Prokb.Data.DataDTO.TiposFicha;
using Prokb.Data.DataDTO.Enums;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Prokb.Data.DataDTO.Servicio
{

    class FichaNoConformidadServicioDTO : FichaNoConformicadDTO
    {
        
        public EstadoServicioDTO Estado { get; set; }
        public string FichaAnalisisId { get; set; }
        
        public string FichaComprasId { get; set; }
       
        public string FichaEjecucionId { get; set; }
        public string FichaArticuculoEFIMEDID { get; set; }
        public string FichaIncidenciaId { get; set; }

    }
}
