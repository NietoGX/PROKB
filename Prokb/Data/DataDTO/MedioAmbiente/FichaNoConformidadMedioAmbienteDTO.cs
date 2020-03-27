using Prokb.Data.Enums;
using Prokb.Data.DataDTO.TiposFicha;
using System.ComponentModel.DataAnnotations;

namespace Prokb.Data.DataDTO.MedioAmbiente
{

    public class FichaNoConformidadMedioAmbienteDTO : FichaNoConformicadDTO
    {
        
        public EstadoEME Estado { get; set; }

        
        public string FichaAnalisisId { get; set; }
        public string FichaEjecucionId { get; set; }
        public string FichaArticuloEFIMEDId { get; set; }
        public string FichaIncidenciaId { get; set; }
    }
}
