using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Prokb.Data.Models.TiposFicha
{
    public class FichaArticuloEFIMED : FichaNoConformidad
    {
        public virtual Proveedor Proveedor { get; set; }
        public int ProveedorId { get; set; }
        public virtual Articulo Articulo { get; set; }
        public int ArticuloId { get; set; }
        public string Ubicacion { get; set; }
        public string Notas { get; set; }

    }
}
