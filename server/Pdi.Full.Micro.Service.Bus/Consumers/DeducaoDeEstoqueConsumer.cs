using System.Threading.Tasks;
using MassTransit;
using Pdi.Full.Micro.Service.Messages;
using Pdi.Full.Micro.Service.Services.Abstractions;

namespace Pdi.Full.Micro.Service.Bus.Consumers
{
    public class DeducaoDeEstoqueConsumer : IConsumer<DeducaoDeEstoqueMessage>
    {
        private readonly IProdutoService _produtoService;

        public DeducaoDeEstoqueConsumer(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        public async Task Consume(ConsumeContext<DeducaoDeEstoqueMessage> context)
        {
            var deducaoDeEstoqueMessage = context.Message;
            await _produtoService.AtualizarEstoqueAsync(deducaoDeEstoqueMessage, context.CancellationToken);
        }
    }
}