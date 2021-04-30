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
    public class QuantidadeDePedidosPorDiaNoMesController : ControllerBase
    {

        private readonly IPedidoService _pedidoService;

        public QuantidadeDePedidosPorDiaNoMesController(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        [HttpGet]
        [Authorize(Policy = Policies.OnlyManagers)]
        public IEnumerable<EntregaPorDia> Get()
        {
            var resultado = _pedidoService.ListarEntregaPorDiaPeriodo30Dias();

            return resultado.ToArray();
        }


    }
}
