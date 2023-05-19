using System;

namespace Pdi.Full.Micro.Service.Entities.Models
{
    public class Produto
    {
        public Guid Id { get; set; }
        public long Sequencial { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public decimal QuantidadeEmEstoque { get; set; }
    }
}