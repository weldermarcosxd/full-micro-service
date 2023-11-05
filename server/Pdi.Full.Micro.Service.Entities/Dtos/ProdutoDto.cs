using System;

namespace Pdi.Full.Micro.Service.Entities.Dtos
{
    public class ProdutoDto
    {
        public Guid Id { get; set; }
        public long Sequencial { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Preco { get; set; }
        public string QuantidadeEmEstoque { get; set; }
    }
}