
using System.ComponentModel.DataAnnotations;
using Prokb.Data.DataDTO.TiposFicha;
using Prokb.Data.Enums;

namespace Prokb.Data.DataDTO.EficienciaEnergetica
{
    public class FichaNoConformidadEficienciaEnergeticaDTO : FichaNoConformicadDTO
    {
        
        public EstadoEME Estado { get; set; }
        public string FichaNoConformidadId { get; set; }
        public string FichaAnalisisId { get; set; }
        public string FichaEjecucionId { get; set; }
        public string FichaArticuloEFIMEDId { get; set; }
        
        public string FichaIncidenciaId { get; set; }
    }
}
