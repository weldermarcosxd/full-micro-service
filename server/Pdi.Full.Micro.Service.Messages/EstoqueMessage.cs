using System;

namespace Pdi.Full.Micro.Service.Messages
{
    public abstract class EstoqueMessage
    {
        public Guid ProdutoId { get; set; }
        public decimal Quantidade { get; set; }
    }
}