using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
public class Usuario
{
    public string Nombre { get; set; }
    [Key]
    public string Email { get; set; }
    public DateTime FechaCreacion { get; set; }

    public DateTime FechaModificacion { get; set; }


}