using System.ComponentModel.DataAnnotations.Schema;

namespace Investimentos.Models
{
    public class CotacaoModel
    {
        public int id { get; set; }
        public DateTime data { get; set; }
        public string indexador { get; set; }

        [Column(TypeName = "decimal(18, 4)")]
        public decimal valor { get; set; }
    }
}
