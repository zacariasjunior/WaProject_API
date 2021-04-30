using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaProject_API.Dto;
using WaProject_API.Service.Authentication.Authorization;
using WaProject_API.Service.Interface;


namespace WaProject_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TotalDePedidosController : Controller
    {

        private readonly IPedidoService _pedidoService;

        public TotalDePedidosController(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }


        [HttpGet]
        [Authorize(Policy = Policies.OnlyManagers)]
        public int Get()
        {
            var resultado = _pedidoService.TotalDePedidos();

            return resultado;
        }
    }
}
