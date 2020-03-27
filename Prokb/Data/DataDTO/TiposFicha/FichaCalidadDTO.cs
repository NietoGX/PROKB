using System;
using System.ComponentModel.DataAnnotations;

namespace Prokb.Data.DataDTO.TiposFicha
{
    class FichaCalidadDTO
    {
        [Key]
        public int Id { get; set; }
        public string FichaReferencia { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaCalidad { get; set; }
        public UsuarioDTO ResponsableCalidad { get; set; }
        public string ResponsableCalidadId { get; set; }
        public MotivoDTO Motivo { get; set; }
        public int MotivoId { get; set; }
        public DecisionDTO Decision { get; set; }
        public int DecisionId { get; set; }
        public string DescripcionProblema { get; set; }
        public string DescripcionSolucion { get; set; }
        public bool Finalizada { get; set; }//define si esta rellenada o no
    }
}
