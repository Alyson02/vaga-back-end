using System.ComponentModel.DataAnnotations;

namespace VeiculoApi.Data.Dtos
{
    public class CreateDonoDto
    {
        [Required(ErrorMessage = "O dono deve ter um nome")]
        [StringLength(100)]
        public string Nome { get; set; }
        public int VeiculoID { get; set; }
    }
}
