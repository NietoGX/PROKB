using System.ComponentModel.DataAnnotations;
namespace Prokb.Data.DataDTO
{
    public class TipoDecisionSeccionDTO
    {
        public int DecisionId { get; set; }
        public int SeccionId { get; set; }
        public DecisionDTO Decision { get; set; }
        public SeccionDTO Seccion { get; set; }
    }
}