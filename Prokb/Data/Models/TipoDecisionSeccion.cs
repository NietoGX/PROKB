using System.ComponentModel.DataAnnotations;

public class TipoDecisionSeccion
{
    public int Id { get; set; }
    public Decision Decision { get; set; }
    public int SeccionId { get; set; }
    public Seccion Seccion { get; set; }
}