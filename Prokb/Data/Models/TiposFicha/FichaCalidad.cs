
using System;
using System.ComponentModel.DataAnnotations;

namespace Prokb.Data.Models.TiposFicha
{
    public class FichaCalidad : FichaNoConformidad
    {

        public DateTime FechaCalidad { get; set; }
        public int ResponsableCalidadId { get; set; }
        public  EmpresaAreaSeccionUsuario ResponsableCalidad { get; set; }
        public int MotivoId { get; set; }
        public virtual Motivo Motivo { get; set; }
        public int DecisionCalidadId { get; set; }
        public virtual TipoDecisionSeccion DecisionCalidad { get; set; }
        public string DescripcionProblema { get; set; }
        public string DescripcionSolucion { get; set; }
        public bool Finalizada { get; set; }//define si esta rellenada o no
    }
}
