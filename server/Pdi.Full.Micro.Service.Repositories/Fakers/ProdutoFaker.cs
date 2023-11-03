using Bogus;
using Pdi.Full.Micro.Service.Entities.Models;

namespace Pdi.Full.Micro.Service.Repositories.Fakers
{
    internal static class ProdutoFaker
    {
        internal static Faker<Produto> Faker(){
            var sequencia = 1;
            return new Faker<Produto>()
            .RuleFor(u => u.Id, f => f.Random.Guid()) 
            .RuleFor(u => u.Sequencial, f => sequencia++) 
            .RuleFor(u => u.Nome, f => f.Commerce.ProductName()) 
            .RuleFor(u => u.Descricao, f => f.Commerce.ProductDescription())
            .RuleFor(u => u.Preco, f => f.Random.Decimal(1,999_999))
            .RuleFor(u => u.QuantidadeEmEstoque, f => f.Random.Decimal(1,999_999));
        }
    }
}