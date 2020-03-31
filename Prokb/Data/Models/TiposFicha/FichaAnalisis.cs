using System;
using System.ComponentModel.DataAnnotations;

namespace Prokb.Data.Models.TiposFicha
{
    public class FichaAnalisis : FichaNoConformidad
    {
        
        public DateTime FechaAnalisis { get; set; }
        public int ResponsableAnalisisId { get; set; }
        public virtual EmpresaAreaSeccionUsuario ResponsableAnalisis { get; set; }
        public bool EsDecision { get; set; }
        public int PropuestaId { get; set; }
        public virtual TipoDecisionSeccion Propuesta {get;set;}//Decision= propuesta
        public int DecisionId { get; set; }
        public virtual TipoDecisionSeccion Decision { get; set; }
        [StringLength(150)]
        public string Descripcion { get; set; }

        
        
    }
}
