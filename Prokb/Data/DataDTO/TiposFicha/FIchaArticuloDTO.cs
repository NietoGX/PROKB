using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace Prokb.Data.DataDTO.TiposFicha
{
    class FIchaArticuloDTO
    {
        [Key]
        public int Id { get; set; }
        public string FichaReferencia { get; set; }
        public int NumAlbaran { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaAlbaran { get; set; }
        public int NumPedido { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaPedido { get; set; }
        public int CantidadTotal { get; set; }
        public int CantidadAfectada { get; set; }
        //public Ubicacion?
        public string Notas { get; set; }


        public int ArticuloId { get; set; }
        public ArticuloDTO Articulo { get; set; }
        public int ProveedorId { get; set; }
        public ProveedorDTO Proveedor { get; set; }


    }
}
