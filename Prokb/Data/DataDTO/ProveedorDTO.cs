using System;
using System.ComponentModel.DataAnnotations;
namespace Prokb.Data.DataDTO
{
    public class ProveedorDTO
    {

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool Interno { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}