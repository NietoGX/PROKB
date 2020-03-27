using System;
using System.ComponentModel.DataAnnotations;

namespace Prokb.Data.DataDTO.TiposFicha
{
    class FichaLogisticaDTO
    {
        [Key]
        public int Id { get; set; }
        public string FichaReferencia { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaLogistica { get; set; }
        public UsuarioDTO ResponsableLogistica { get; set; }
        public int ResponsableLogisticaId { get; set; }
        public DecisionDTO Decision { get; set; }
        public int DecisionId { get; set; }
        public string DescripcionLogistica { get; set; }
        public bool Finalizada { get; set; }//define si esta rellenada o no
    }
}
