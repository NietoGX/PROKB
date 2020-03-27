
using System;
using System.ComponentModel.DataAnnotations;

namespace Prokb.Data.Models.TiposFicha
{
    public class FichaCalidad : FichaNoConformidad
    {

        public DateTime FechaCalidad { get; set; }
        public string ResponsableCalidadId { get; set; }
        public EmpresaAreaSeccionUsuario ResponsableCalidad { get; set; }
        public int MotivoId { get; set; }
        public Motivo Motivo { get; set; }
        public int DecisionCalidadId { get; set; }
        public TipoDecisionSeccion DecisionCalidad { get; set; }
        public string DescripcionProblema { get; set; }
        public string DescripcionSolucion { get; set; }
        public bool Finalizada { get; set; }//define si esta rellenada o no
    }
}
