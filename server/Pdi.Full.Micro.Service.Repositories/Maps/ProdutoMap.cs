using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pdi.Full.Micro.Service.Entities.Models;

namespace Pdi.Full.Micro.Service.Repositories.Maps
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.Sequencial).ValueGeneratedOnAdd();

            builder.Property(x => x.Nome).IsUnicode(false).HasMaxLength(100);
            builder.Property(x => x.Descricao).IsUnicode(false).HasMaxLength(500);
        }
    }
}