using Prokb.Data.Enums;
using Prokb.Data.Models.TiposFicha;

namespace Prokb.Data.Models
{

    public class FichaNoConformidadMedioAmbiente : FichaNoConformidad
    {
        
        public EstadoEME Estado { get; set; }

        public string FichaAnalisisId { get; set; }
        public FichaAnalisis FichaAnalisis { get; set; }
        public string FichaEjecucionId { get; set; }
        public FichaEjecucion FichaEjecucion { get; set; }
        public string FichaArticuloEFIMEDId { get; set; }
        public FichaArticuloEFIMED FichaArticuloEFIMED { get; set; }
        public FichaIncidencia FichaIncidencia { get; set; }
        public string FichaIncidenciaId { get; set; }
    }
}
