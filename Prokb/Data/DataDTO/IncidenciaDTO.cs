using System;
using System.ComponentModel.DataAnnotations;
namespace Prokb.Data.DataDTO
{
    public class IncidenciaDTO
    {
        
        public int Id { get; set; }
        
        public string Descripcion { get; set; }
        public bool Inactivo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}