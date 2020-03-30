using System;
using System.ComponentModel.DataAnnotations;

namespace Prokb.Data.Models.TiposFicha
{
    public class FichaAnalisis : FichaNoConformidad
    {
        
        public DateTime FechaAnalisis { get; set; }
        public int ResponsableAnalisisId { get; set; }
        public EmpresaAreaSeccionUsuario ResponsableAnalisis { get; set; }
        public int PropuestaId { get; set; }
        public Decision Propuesta{get;set;}//Decision= propuesta
        public int DecisionId { get; set; }
        public Decision Decision { get; set; }
        public string Descripcion { get; set; }

        
        
    }
}
