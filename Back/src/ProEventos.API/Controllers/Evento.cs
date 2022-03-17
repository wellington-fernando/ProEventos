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
        public IEnumerable<Evento> _evento = new Evento[]
       {
             new Evento()
            {
                EventoId = 1,
                Tema = "angular 11 e .net 5",
                Local = "Limeira",
                Lote = "1º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImageURL = "fotos.png"
            },
                new Evento()
            {
                EventoId = 2,
                Tema = "angula2",
                Local = "Limeirasdfasdfa",
                Lote = "1º Lote",
                QtdPessoas = 25550,
                DataEvento = DateTime.Now.AddDays(4).ToString(),
                ImageURL = "fotasassaos.png"
            }

       };



        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet ("{id}")] //RAPAZZZZ AQUI COMEÇA A FICAR BEM INTERESSANTE QUANDO USADO DESTA FORMA
        public IEnumerable<Evento> GetbyId(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPost]

        public string Post()
        {
            return "Exemplo de Post";
        }


    }

}

