using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        public readonly DataContext _context;
        public EventosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Evento;
        }
        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _context.Evento.FirstOrDefault(eventos => eventos.Id == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de post {id}";
        }

        [HttpPatch("{id}")]
        public string Patch(int id)
        {
            return $"Exemplo de patch {id}";
        }

        [HttpDelete("{id}")]
        public string HttpDelete(int id)
        {
            return $"Exemplo de delete {id}";
        }
    }
}
