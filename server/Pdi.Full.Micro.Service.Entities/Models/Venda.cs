using System;
using System.Collections.Generic;

namespace Pdi.Full.Micro.Service.Entities.Models
{
    public class Venda
    {
        public Guid Id { get; set; }
        public long Sequencial { get; set; }
        public DateTime DataDaVenda { get; set; }
        public IEnumerable<ItemDaVenda> Itens { get; set; }
    }
}