using Prokb.Data.Models;
using System;

public class Area
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string EmpresaId { get; set; }
    public virtual Empresa Empresa { get; set; }
    public string Responsable1Id { get; set; }
    public string Responsable2Id { get; set; }

    public string DirectorId { get; set; }
    public DateTime FechaCreacion { get; set; }
    public DateTime FechaModificacion { get; set; }


}
