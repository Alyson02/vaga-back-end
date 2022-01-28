using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using VeiculoApi.Data;
using VeiculoApi.Data.Dtos;
using VeiculoApi.Models;

namespace VeiculoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DonoController : ControllerBase
    {
        private VeiculoContext _context;
        private IMapper _mapper;

        public DonoController(VeiculoContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        [HttpPost]
        public IActionResult AdicionaDono([FromBody] CreateDonoDto donoDto)
        {
            var dono = _mapper.Map<Dono>(donoDto);
            _context.Donos.Add(dono);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaDonoPorId), new { Id = dono.Id }, dono);
        }

        [HttpGet]
        public IActionResult RecuperaDono()
        {
            return Ok(_context.Donos);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaDonoPorId(int id)
        {
            var dono = _context.Donos.FirstOrDefault(donos => donos.Id == id);
            if (dono != null)
            {
                ReadDonoDto donoDto = _mapper.Map<ReadDonoDto>(dono);
                return Ok(dono);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaDono(int id, [FromBody] UpdateDonoDto donoDto)
        {
            var donos = _context.Donos.FirstOrDefault(donos => donos.Id == id);
            if (donos == null)
            {
                return NotFound();
            }
            _mapper.Map(donoDto, donos);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarDono(int id)
        {
            var dono = _context.Donos.FirstOrDefault<Dono>(donos => donos.Id == id);
            if (dono == null)
            {
                return NotFound();
            }
            _context.Remove(dono);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
