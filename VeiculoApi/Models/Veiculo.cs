using System.ComponentModel.DataAnnotations;

namespace VeiculoApi.Models
{
    public class Veiculo
    {
        [Required(ErrorMessage = "Deve ter um id")]
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        [Required(ErrorMessage = "O modelo é obrigatório")]
        public string Modelo { get; set; }
        [StringLength(100)]
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; }
    }
}
