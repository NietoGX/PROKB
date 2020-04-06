using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Prokb.Data.DataDTO.TiposFicha
{
    class FichaIncidenciaDTO : FichaNoConformicadDTO
    {
       
        public bool EsGrave { get; set; }
        public IncidenciaDTO TipoIncidencia { get; set; }
        public int TipoIncidenciaId{get;set; }
       
        public string DescripcionIncidencia { get; set; }
        public bool AfectaProduccion { get; set; }
        public bool EsPropuesta { get; set; }//Si no es propuesta es decision
        public DecisionDTO Decision { get; set; }
        public int DecisionId { get; set; }
        public DecisionDTO Propuesta { get; set; }
        public int PropuestaId { get; set; }
        
    }
}
