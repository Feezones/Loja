using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Loja.API.Data;
using Loja.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Loja.API.Controllers
{
    [Route("api/[controller]")]
    public class ItensController : Controller
    {
        private readonly DataContext _context;

        public ItensController(DataContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public IEnumerable<Item> Get()
        {
            return _context.Itens;
        }

        [HttpGet("{id}")]
        public Item GetById(int id)
        {
            return  _context.Itens.FirstOrDefault(
                item => item.ItemId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo do post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete com id = {id}";
        }
    }
}