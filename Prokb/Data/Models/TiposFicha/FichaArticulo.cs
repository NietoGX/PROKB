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
        public int CantidadTotal { get; set; }
        public int CantidadAfectada { get; set; }
        //public Ubicacion?
        public string Notas { get; set; }




    }
}
