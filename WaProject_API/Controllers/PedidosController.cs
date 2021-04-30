using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaProject_API.Infra.Context;
using WaProject_API.Infra.Repository.Interface;
using WaProject_API.Models;
using WaProject_API.Service.Interface;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using WaProject_API.Service.Authentication.Authorization;

namespace WaProject_API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PedidosController : ControllerBase
    {

        private readonly IPedidoService _pedidoService;

        public PedidosController(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

       

        [HttpGet]
        [Authorize(Policy = Policies.OnlyManagers)]
        public IEnumerable<Pedido> Get(int pageNum, int pageSize)
        {
            var resultado = _pedidoService.ListarTodosPedidosComEquipeProdutosAdo(pageNum, pageSize);

            return resultado.ToArray();
        }
    }
}
