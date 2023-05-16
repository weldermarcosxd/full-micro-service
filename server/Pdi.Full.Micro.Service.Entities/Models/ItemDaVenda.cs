using System;

namespace Pdi.Full.Micro.Service.Entities.Models
{
    public class ItemDaVenda
    {
        public int Sequencial { get; set; }
        public Guid ProdutoId { get; set; }
        public Guid VendaId { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal Quantidade { get; set; }
        public decimal PercentualDeDesconto { get; set; }
        public decimal ValorTotalDosItens { get; set; }
    }
}