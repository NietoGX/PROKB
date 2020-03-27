using System.ComponentModel.DataAnnotations;
namespace Prokb.Data.DataDTO
{
    public class TipoDecisionSeccionDTO
    {
        [Key]
        public int IdDecision { get; set; }
        public int IdSeccion { get; set; }
        public DecisionDTO Decision { get; set; }
        public SeccionDTO Seccion { get; set; }
    }
}