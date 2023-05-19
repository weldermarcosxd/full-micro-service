using Pdi.Full.Micro.Service.Entities;

namespace Pdi.Full.Micro.Service.Services.Abstractions
{
    public interface ITokenService
    {
        string GerarToken(Usuario usuario);
    }
}