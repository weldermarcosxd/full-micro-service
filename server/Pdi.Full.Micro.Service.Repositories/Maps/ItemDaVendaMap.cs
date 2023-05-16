using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pdi.Full.Micro.Service.Entities.Models;

namespace Pdi.Full.Micro.Service.Repositories.Maps
{
    public class ItemDaVendaMap : IEntityTypeConfiguration<ItemDaVenda>
    {
        public void Configure(EntityTypeBuilder<ItemDaVenda> builder)
        {
            builder.HasKey(x => new { x.ProdutoId, x.VendaId });
        }
    }
}