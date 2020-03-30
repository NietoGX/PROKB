using System.ComponentModel.DataAnnotations;

public class TipoIncidenciaSeccion
{
    public int Id { get; set; }
    public virtual Seccion Seccion { get; set; }
    public int IncidenciaId { get; set; }
    public virtual Incidencia Incidencia { get; set; }
}