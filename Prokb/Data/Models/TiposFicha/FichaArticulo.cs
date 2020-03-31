using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Prokb.Data.Models.TiposFicha
{
    public class FichaArticulo : FichaNoConformidad
    {
       
        public int NumAlbaran { get; set; }

        public DateTime FechaAlbaran { get; set; }

        public int NumPedido { get; set; }

        public DateTime FechaPedido { get; set; }
        [StringLength(50)]
        public string CantidadTotal { get; set; }
        [StringLength(50)]
        public string CantidadAfectada { get; set; }
        public virtual Proveedor Proveedor { get; set; }
        public int ProveedorId { get; set; }
        public virtual Articulo Articulo { get; set; }
        public int ArticuloId { get; set; }
        [StringLength(50)]
        public string Ubicacion { get; set; }
        [StringLength(150)]
        public string Notas { get; set; }

    }
}
