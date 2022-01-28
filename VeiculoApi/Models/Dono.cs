using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VeiculoApi.Models
{
    public class Dono
    {
        [Required (ErrorMessage = "Deve ter um id")]
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O dono deve ter um nome")]
        [StringLength(100)]
        public string Nome { get; set; }
        public int VeiculoID { get; set; }
        public Veiculo Veiculo { get; set; }

    }
}
