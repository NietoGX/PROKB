using System;
using System.Collections.Generic;

namespace Prokb.Data.Models.TiposFicha
{
    public abstract class FichaNoConformidad
    {
        public int Id { get; set; }
        public string FichaReferencia { get; set; }
        public virtual Empresa Empresa { get; set; }
        public int EmpresaId { get; set; }
        public string EmisorId { get; set; }
        public virtual EmpresaAreaSeccionUsuario Emisor { get; set; }
        public int AreaId { get; set; }
        public virtual Area Area { get; set; }
        public int SeccionId { get; set; }
        public virtual Seccion Seccion { get; set; }
    
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public virtual ICollection<Documento> Documentos { get; set; }


    }
}