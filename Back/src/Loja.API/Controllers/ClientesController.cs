using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loja.Domain;
using Loja.Persistence;
using Loja.Persistence.Contexto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Loja.Application.Contrato;

namespace Loja.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {
       
        public ClientesController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try{
                var clientes = await _clienteService.GetAllClientesAsync(true);
                if(clientes == null) return NotFound("Nenhum cliente encontrado");
            }catch(System.Exception){
                throw;
            }
        }

        [HttpGet("{id}")]
        public Cliente GetById(int id)
        {
            return  _context.Clientes.FirstOrDefault(
                cliente => cliente.Id == id);
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
