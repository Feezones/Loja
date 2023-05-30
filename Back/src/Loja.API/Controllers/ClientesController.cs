using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loja.API.Data;
using Loja.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Loja.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {
       
        private readonly DataContext _context;

       public ClientesController(DataContext context){
            this._context = context;

       }

        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            return _context.Clientes;
        }

        [HttpGet("{id}")]
        public Cliente GetById(int id)
        {
            return  _context.Clientes.FirstOrDefault(
                cliente => cliente.ClienteId == id);
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
