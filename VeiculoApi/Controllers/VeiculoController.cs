using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using VeiculoApi.Data;
using VeiculoApi.Data.Dtos;
using VeiculoApi.Models;
using VeiculoApi.Profiles;

namespace VeiculoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VeiculoController : ControllerBase
    {
        private VeiculoContext _context;
        private IMapper _mapper;

        public VeiculoController(VeiculoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionaVeiculo([FromBody] CreateVeiculoDto veiculoDto)
        {
            var veiculo = _mapper.Map<Veiculo>(veiculoDto);
            _context.Veiculos.Add(veiculo);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaVeiculoPorId), new {Id = veiculo.Id}, veiculo);
        }

        [HttpGet]
        public IActionResult RecuperaVeiculo()
        {
            return Ok(_context.Veiculos);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaVeiculoPorId(int id)
        {
            var veiculo = _context.Veiculos.FirstOrDefault(veiculos => veiculos.Id == id);
            if (veiculo != null)
            {
                ReadVeiculoDto veiculoDto = _mapper.Map<ReadVeiculoDto>(veiculo);
                return Ok(veiculoDto);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaVeiculo(int id, [FromBody] UpdateVeiculoDto veiculoDto)
        {
            var veiculos = _context.Veiculos.FirstOrDefault(veiculos => veiculos.Id == id);
            if (veiculos == null)
            {
                return NotFound();
            }
            _mapper.Map(veiculoDto, veiculos);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarVeiculo(int id)
        {
            var veiculo = _context.Veiculos.FirstOrDefault<Veiculo>(veiculos => veiculos.Id == id);
            if (veiculo == null)
            {
                return NotFound();
            }
            _context.Remove(veiculo);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
