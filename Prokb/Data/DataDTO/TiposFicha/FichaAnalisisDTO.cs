using System;
using System.ComponentModel.DataAnnotations;

namespace Prokb.Data.DataDTO.TiposFicha
{
    class FichaAnalisisDTO
    {
        [Key]
        public int Id { get; set; }
        public string FichaReferencia { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaAnalisis { get; set; }
        public UsuarioDTO ResponsableAnalisis { get; set; }
        public int ResponsableAnalisisId { get; set; }
        public DecisionDTO Propuesta { get; set; }
        public int PropuestaId { get; set; }
        public DecisionDTO Decision { get; set; }
        public int DecisionId { get; set; }
        public string Descripcion { get; set; }
        
    }
}
