using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        public IEnumerable<Eventos> _evento = new Eventos[]
        {
            new Eventos(){
                EventoId = 1,
                Tema = "Angular 12 e .Net 5",
                Local = "Rio Grande",
                Lote = "1° Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
            }
        };
        public EventosController()
        {
        }

        [HttpGet]
        public IEnumerable<Eventos> Get()
        {
            return _evento;
        }
        [HttpGet("{id}")]
        public IEnumerable<Eventos> GetById(int id)
        {
            return _evento.Where(eventos => eventos.EventoId == id);
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
