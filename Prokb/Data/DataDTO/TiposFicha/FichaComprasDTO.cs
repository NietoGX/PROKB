using System;
using System.ComponentModel.DataAnnotations;

namespace Prokb.Data.DataDTO.TiposFicha
{
    class FichaComprasDTO
    {

        public int Id { get; set; }
        public string FichaReferencia { get; set; }

        public DateTime FechaCompras { get; set; }

        public int ResponsableComprasId { get; set; }

        public int PropuestaId { get; set; }
        public int DecisionId { get; set; }
        public string Descripcion { get; set; }
        public bool Finalizada { get; set; }//define si esta rellenada o no
    }
}
