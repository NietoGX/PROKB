

using Prokb.Data.Enums;
using Prokb.Data.Models.TiposFicha;

namespace Prokb.Data.Models
{

    public class FichaNoConformidadServicio : FichaNoConformidad
    {
        
        public EstadoServicio Estado { get; set; }
        public string FichaAnalisisId { get; set; }
        public virtual FichaAnalisis FichaAnalisis { get; set; }
        public string FichaComprasId { get; set; }
        public virtual FichaCompras FichaCompras { get; set; }
        public string FichaEjecucionId { get; set; }
        public virtual FichaEjecucion FichaEjecucion { get; set; }
        public string FichaArticuloEFIMEDId { get; set; }
        public virtual FichaArticuloEFIMED FichaArticuloEFIMED {get;set;}
        public string FichaIncidenciaId { get; set; }
        public virtual FichaIncidencia FichaIncidencia { get; set; }

    }
}
