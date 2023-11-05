using System.Linq;
using Pdi.Full.Micro.Service.Entities.Dtos;
using Pdi.Full.Micro.Service.Entities.Models;
using Riok.Mapperly.Abstractions;

namespace Pdi.Full.Micro.Service.Entities.Mapers
{
    [Mapper]
    public static partial class ProdutoMapper
    {
        public static partial IQueryable<ProdutoDto> ProjetarParaDto(this IQueryable<Produto> q);
    }
}