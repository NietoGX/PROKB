using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Seccion 
{
    public int Id { get; set; }
    public string NombreSeccion { get; set; }
    public int AreaId { get; set; }
    public Area Area { get; set; }
    
    public DateTime FechaCreacion { get; set; }
    public DateTime FechaModificacion { get; set; }
   
}