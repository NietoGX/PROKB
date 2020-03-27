using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Prokb.Data.DataDTO
{
    public class EmpresaDTO

    {
        [Key]
        public string IdEmpresa { get; set; }

        [Required]
        public string NombreEmpresa { get; set; }

        public ICollection<AreaDTO> Areas;

        public ICollection<EmpresaAreaSeccionUsuarioDTO> Roles;
    }
}
