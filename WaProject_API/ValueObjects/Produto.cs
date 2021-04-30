using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WaProject_API.ValueObjects
{
    public class Produto
    {
        public int Id { get; set; }
        public int PedidoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
    }
}
