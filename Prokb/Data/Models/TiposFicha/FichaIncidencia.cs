using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Prokb.Data.Models.TiposFicha
{
    public class FichaIncidencia : FichaNoConformidad
    {

        public bool EsGrave { get; set; }
        public virtual ICollection<TipoIncidenciaSeccion> TiposIncidencia{get;set; }
        //public List<int> TiposIncidenciaId { get; set; }
        public string DescripcionIncidencia { get; set; }
        public bool AfectaProduccion { get; set; }
        public bool EsPropuesta { get; set; }//Si no es propuesta es decision
        public int DecisionIncidenciaId { get; set; }
        public virtual TipoDecisionSeccion DecisionIncidencia { get; set; }
        public int PropuestaIncidenciaId { get; set; }
        public virtual TipoDecisionSeccion PropuestaIncidencia { get; set; }
        
    }
}
