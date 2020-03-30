using System.ComponentModel.DataAnnotations;

public class TipoDecisionSeccion
{
    public int Id { get; set; }
    public virtual Decision Decision { get; set; }
    public int SeccionId { get; set; }
    public virtual Seccion Seccion { get; set; }
}