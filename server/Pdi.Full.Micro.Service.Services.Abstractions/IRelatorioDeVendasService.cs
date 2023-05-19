using System.Threading;
using System.Threading.Tasks;

namespace Pdi.Full.Micro.Service.Services.Abstractions
{
    public interface IRelatorioDeVendasService
    {
        Task<byte[]> ObterAsync(CancellationToken cancellationToken);
    }
}