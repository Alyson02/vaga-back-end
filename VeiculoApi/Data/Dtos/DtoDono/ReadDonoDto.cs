using System;
using System.ComponentModel.DataAnnotations;
using VeiculoApi.Models;

namespace VeiculoApi.Data.Dtos
{
    public class ReadDonoDto
    {
        [Required(ErrorMessage = "Deve ter um id")]
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O dono deve ter um nome")]
        [StringLength(100)]
        public string Nome { get; set; }
        public int VeiculoID { get; set; }
        private DateTime _Hora = DateTime.Now;
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime HoraDaConsulta { get => _Hora; set { HoraDaConsulta = _Hora; } }
    }
}
