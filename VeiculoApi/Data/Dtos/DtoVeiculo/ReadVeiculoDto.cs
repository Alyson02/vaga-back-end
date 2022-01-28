using System;
using System.ComponentModel.DataAnnotations;

namespace VeiculoApi.Data.Dtos
{
    public class ReadVeiculoDto
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
        private DateTime _Hora = DateTime.Now;
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime HoraDaConsulta { get => _Hora; set {HoraDaConsulta = _Hora;} }
    }
}
