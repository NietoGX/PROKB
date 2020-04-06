using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace Prokb.Data.DataDTO.TiposFicha
{
    class FIchaArticuloDTO : FichaNoConformicadDTO
    {
        
        
        public int NumAlbaran { get; set; }
        public DateTime FechaAlbaran { get; set; }
        public int NumPedido { get; set; }
        public DateTime FechaPedido { get; set; }
        public int CantidadTotal { get; set; }
        public int CantidadAfectada { get; set; }
        public string Ubicación { get; set; }
        public string Notas { get; set; }


        public int ArticuloId { get; set; }
        public ArticuloDTO Articulo { get; set; }
        public int ProveedorId { get; set; }
        public ProveedorDTO Proveedor { get; set; }


    }
}
