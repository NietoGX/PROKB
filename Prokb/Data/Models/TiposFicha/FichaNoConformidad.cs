using System;
using System.Collections.Generic;

namespace Prokb.Data.Models.TiposFicha
{
    public abstract class FichaNoConformidad
    {
        public int Id { get; set; }
        public string FichaReferencia { get; set; }
        public string EmisorId { get; set; }
        public EmpresaAreaSeccionUsuario Emisor { get; set; }
        public int ProveedorId { get; set; }
        public Proveedor Proveedor {get;set;}
        public int ArticuloId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public ICollection<Documento> Documentos { get; set; }


    }
}