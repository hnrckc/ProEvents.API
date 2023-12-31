﻿using System;
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
        public IEnumerable <Evento> _evento = new Evento[]{
                new Evento() {
                    EventoID = 1,
                    Tema = "Angular 11 e .NET 5",
                    Local = "Curitiba",
                    Lote = "Primeiro Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    ImageURL = "foto.png"
                },

                new Evento() {
                    EventoID = 2,
                    Tema = "Angular 11 e .NET 5 e BD",
                    Local = "Fazenda Rio Grande",
                    Lote = "Segundo Lote",
                    QtdPessoas = 350,
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                    ImageURL = "foto1.png"
                }
            };
        public EventoController()
        {

        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetByID(int id)
        {
            return _evento.Where(evento => evento.EventoID == id);
        } 
    }
}
