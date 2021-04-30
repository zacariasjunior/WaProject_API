using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaProject_API.Service.Interface;

namespace WaProject_API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AddPedidosController : Controller
    {
        private readonly IPedidoService _pedidoService;

        public AddPedidosController(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }


        [HttpGet]      
        public IEnumerable<string> Get()
        {
            _pedidoService.AddPedidos();

            var retorno = new string[1];

            return retorno;
        }
    }
}
