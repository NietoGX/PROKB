﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Prokb.Data.Models.TiposFicha
{
    public class FichaLogistica : FichaNoConformidad
    {

        public DateTime FechaLogistica { get; set; }
        public int ResponsableLogisticaId { get; set; }
        public virtual EmpresaAreaSeccionUsuario ResponsableLogistica { get; set; }
        public int DecisionLogisticaId { get; set; }
        public virtual TipoDecisionSeccion DecisionLogistica { get; set; }
        public string DescripcionLogistica { get; set; }
        public bool Finalizada { get; set; }//define si esta rellenada o no
    }
}
