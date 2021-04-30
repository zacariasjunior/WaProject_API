using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WaProject_API.ValueObjects
{
    
    public class Equipe
    {
        public int Id { get; set; }
        public int PedidoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string PlacaDoVeiculo { get; set; }
    }
}
