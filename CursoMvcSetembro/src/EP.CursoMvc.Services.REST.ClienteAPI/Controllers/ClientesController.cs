using Ep.CursoMvc.Application.Intefaces;
using Ep.CursoMvc.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace EP.CursoMvc.Services.REST.ClienteAPI.Controllers
{
    public class ClientesController : ApiController
    {
        private readonly IClienteAppService _clienteAppService;

        public ClientesController(IClienteAppService clienteAppService)
        {
            _clienteAppService = clienteAppService;
        }

        // GET: api/Clientes

        //public IEnumerable<string> Get()
        [HttpGet]
        public IEnumerable<ClienteViewModel> ListarTodos()
        {
            return _clienteAppService.ObterTodos();
        }

        // GET: api/Clientes/5
        public ClienteViewModel Get(Guid id)
        {
            return _clienteAppService.ObterPorId(id);
        }

        // POST: api/Clientes
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Clientes/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Clientes/5
        public void Delete(int id)
        {
        }
    }
}


//public class ClientList
//{
//    public List<Cliente> Clientes { get; set; }
//}

//public class Cliente
//{
//    public string ClienteId { get; set; }
//    public string Nome { get; set; }
//    public string Email { get; set; }
//    public string CPF { get; set; }
//    public DateTime DataNascimento { get; set; }
//    public DateTime DataCadastro { get; set; }
//    public bool Ativo { get; set; }
//}

