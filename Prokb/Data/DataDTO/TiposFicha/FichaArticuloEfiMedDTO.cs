using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Prokb.Data.DataDTO.TiposFicha
{
    class FichaArticuloEfiMedDTO : FichaNoConformicadDTO
    {
        
      
        public string Ubicacion { get; set; }
        public string Notas { get; set; }
        public int ArticuloId { get; set; }
        public ArticuloDTO Articulo { get; set; }
        public int ProveedorId { get; set; }
        public ProveedorDTO Proveedor { get; set; }
    }
}
