using System.ComponentModel.DataAnnotations;

public class TipoIncidenciaSeccion
{
    public int Id { get; set; }
    public Seccion Seccion { get; set; }
    public int IncidenciaId { get; set; }
    public Incidencia Incidencia { get; set; }
}