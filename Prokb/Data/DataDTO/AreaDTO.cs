
using System;
using System.ComponentModel.DataAnnotations;


namespace Prokb.Data.DataDTO
{
    public class AreaDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string EmpresaId { get; set; }
        public string Responsable1Id { get; set; }
        public string Responsable2Id { get; set; }
        public string DirectorId { get; set; }

        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }


    }
}
