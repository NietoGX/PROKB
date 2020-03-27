using System;
using System.ComponentModel.DataAnnotations;

public class Incidencia
{
    public string Descripcion { get; set; }
    public bool Inactivo { get; set; }
    public DateTime FechaCreacion { get; set; }
    public DateTime FechaModificacion { get; set; }
}