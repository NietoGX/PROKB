using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Prokb.Data.DataDTO
{
    public class SeccionDTO
    {
        public int Id { get; set; }
        
        public int AreaId { get; set; }
        
        public string NombreSeccion { get; set; }
        
        public DateTime FechaCreacion { get; set; }
        
        public DateTime FechaModificacion { get; set; }

    }
}