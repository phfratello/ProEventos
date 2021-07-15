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
    public class EventoController : ControllerBase
    {
       
        public EventoController()
        {
        }

        [HttpGet]
        public Evento Get()
        {  
            return new Evento(){
                EventoId = 1,
                Tema = "Angular 11  e .NET 5",
                Local = "Belo Horizonte",
                Lote = "1º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemURL = "foto.png"
            };
        }

        [HttpPost]  // criação
        public string Post()
        {  
            return "Exemplo de Post";
        }

          [HttpPut("{id}")]  // substitui o objeto inteiro
        public string Put(int id)
        {  
            return $"Exemplo de Put com id = {id}";
        }

             [HttpDelete("{id}")]  // deletar objetos
        public string Delete(int id)
        {  
            return $"Exemplo de Delete com id = {id}";
        }
    }
}
