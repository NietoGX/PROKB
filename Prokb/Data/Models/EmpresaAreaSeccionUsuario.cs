using Prokb.Data.Models;

public class EmpresaAreaSeccionUsuario
{
    public int Id { get; set; }
    public string EmpresaId { get; set; }
    public virtual Empresa Empresa { get; set; }
    public int AreaId { get; set; }
    public virtual Area Area { get; set; }
    public int SeccionId { get; set; }
    public virtual Seccion Seccion {get;set;}
    public string UsuarioId { get; set; }
    public virtual Usuario Usuario { get; set; }

}