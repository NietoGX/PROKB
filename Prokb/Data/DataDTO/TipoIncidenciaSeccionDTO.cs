using System.ComponentModel.DataAnnotations;
namespace Prokb.Data.DataDTO
{
    public class TipoIncidenciaSeccionDTO
    {
        [Key]
        public int IdSeccion { get; set; }
        public int IdIncidencia { get; set; }
        public SeccionDTO Seccion { get; set; }
        public IncidenciaDTO Incidencia { get; set; }
    }
}