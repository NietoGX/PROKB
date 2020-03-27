using System;
using System.ComponentModel.DataAnnotations;
namespace Prokb.Data.DataDTO
{
    public class IncidenciaDTO
    {
        [Key]
        public int IdIncidencia { get; set; }
        [Required]
        public string Descripcion { get; set; }
        public bool Inactivo { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaCreacion { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaModificacion { get; set; }
    }
}