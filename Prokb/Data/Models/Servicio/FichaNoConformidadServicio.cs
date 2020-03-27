

using Prokb.Data.Enums;
using Prokb.Data.Models.TiposFicha;

namespace Prokb.Data.Models
{

    public class FichaNoConformidadServicio : FichaNoConformidad
    {

        public EstadoServicio Estado { get; set; }
        public string FichaAnalisisId { get; set; }
        public FichaAnalisis FichaAnalisis { get; set; }
        public string FichaComprasId { get; set; }
        public FichaCompras FichaCompras { get; set; }
        public string FichaEjecucionId { get; set; }
        public FichaEjecucion FichaEjecucion { get; set; }
        public string FichaArticuloEFIMEDID { get; set; }
        public FichaArticuloEFIMED FichaArticuloEFIMED{get;set;}
        public string FichaIncidenciaId { get; set; }
        public FichaIncidencia FichaIncidencia { get; set; }

    }
}
