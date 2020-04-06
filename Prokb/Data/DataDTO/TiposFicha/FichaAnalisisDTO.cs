using System;
using System.ComponentModel.DataAnnotations;

namespace Prokb.Data.DataDTO.TiposFicha
{
    class FichaAnalisisDTO: FichaNoConformicadDTO
    {
        
       
        
        public DateTime FechaAnalisis { get; set; }
        public UsuarioDTO ResponsableAnalisis { get; set; }
        public int ResponsableAnalisisId { get; set; }
        
        public int PropuestaId { get; set; }
        
        public int DecisionId { get; set; }
        public string Descripcion { get; set; }
        
    }
}
