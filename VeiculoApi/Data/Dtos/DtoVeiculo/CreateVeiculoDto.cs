using System.ComponentModel.DataAnnotations;

namespace VeiculoApi.Data.Dtos
{
    public class CreateVeiculoDto
    {
        [StringLength(100)]
        [Required(ErrorMessage = "O modelo é obrigatório")]
        public string Modelo { get; set; }
        [StringLength(100)]
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; }
    }
}
