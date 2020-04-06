using System.ComponentModel.DataAnnotations;
namespace Prokb.Data.DataDTO
{
    public class TipoIncidenciaSeccionDTO
    {

        public int SeccionId { get; set; }
        public int IncidenciaId { get; set; }
        public SeccionDTO Seccion { get; set; }
        public IncidenciaDTO Incidencia { get; set; }
    }
}