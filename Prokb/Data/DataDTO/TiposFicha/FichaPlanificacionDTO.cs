using System;
using System.ComponentModel.DataAnnotations;

namespace Prokb.Data.DataDTO.TiposFicha
{

    class FichaPlanificacionDTO
    {

        public int Id { get; set; }
        public string FichaReferencia { get; set; }

        public DateTime FechaPlanificacion { get; set; }

        public int ResponsablePlanificacionId { get; set; }

        public int DecisionId { get; set; }
        public int CantidadDevuelta { get; set; }
        public int CantidadConforme { get; set; }
        public string GastosACargoDe { get; set; }
        public string ComentarioProveedor { get; set; }
        public string DescripcionDecision { get; set; }

        public bool Finalizada { get; set; }//define si esta rellenada o no
    }
}
