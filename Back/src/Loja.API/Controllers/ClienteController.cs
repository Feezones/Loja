using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loja.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Loja.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
       public IEnumerable<Cliente> _cliente = new Cliente[]{
         new Cliente(){
                ClienteId=1,
                Nome="Felipe",
                Sobrenome="Brag",
                CPF="123.456.123-23",
                Email="felipebrag@gmail.com",
                Senha="felipe13",
                ConfSenha="felipe13",
                },
                new Cliente(){
                ClienteId=2,
                Nome="Felipe",
                Sobrenome="Brag",
                CPF="123.456.123-23",
                Email="felipebrag@gmail.com",
                Senha="felipe13",
                ConfSenha="felipe13",
                }
       };

       public ClienteController(){

       }

        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            return _cliente;
        }

        [HttpGet("{id}")]
        public IEnumerable<Cliente> GetById(int id)
        {
            return _cliente.Where(cliente => cliente.ClienteId == id);
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
