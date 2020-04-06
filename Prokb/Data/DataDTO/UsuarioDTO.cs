using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Prokb.Data.DataDTO
{
    public class UsuarioDTO
    {
        
        public string Nombre { get; set; }
        
        public string Email { get; set; }
        
        public DateTime FechaCreacion { get; set; }

        public DateTime FechaModificacion { get; set; }



    }
}