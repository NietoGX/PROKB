using System;
using System.ComponentModel.DataAnnotations;

namespace Prokb.Data.Models.TiposFicha
{
    public class FichaCompras : FichaNoConformidad
    {

        public DateTime FechaCompras { get; set; }
        public int ResponsableComprasId { get; set; }
        public EmpresaAreaSeccionUsuario ResponsableCompras { get; set; }
        public int PropuestaId { get; set; }
        public TipoDecisionSeccion PropuestaCompras { get; set; }
        public int DecisionComprasId { get; set; }
        public TipoDecisionSeccion DecisionCompras { get; set; }

        public string Descripcion { get; set; }
        public bool Finalizada { get; set; }//define si esta rellenada o no
    }
}
