using Prokb.Data.Models;

public class EmpresaAreaSeccionUsuario
{
    public int Id { get; set; }
    public string EmpresaId { get; set; }
    public Empresa Empresa { get; set; }
    public int AreaId { get; set; }
    public Area Area { get; set; }
    public int SeccionId { get; set; }
    public Seccion Seccion {get;set;}
    public string UsuarioId { get; set; }
    public Usuario Usuario { get; set; }

}