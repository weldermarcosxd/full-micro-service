using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pdi.Full.Micro.Service.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Sequencial = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", unicode: false, maxLength: 100, nullable: true),
                    Descricao = table.Column<string>(type: "TEXT", unicode: false, maxLength: 500, nullable: true),
                    Preco = table.Column<decimal>(type: "TEXT", nullable: false),
                    QuantidadeEmEstoque = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Sequencial);
                });

            migrationBuilder.CreateTable(
                name: "Vendas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Sequencial = table.Column<long>(type: "INTEGER", nullable: false),
                    DataDaVenda = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItensDasVendas",
                columns: table => new
                {
                    ProdutoId = table.Column<Guid>(type: "TEXT", nullable: false),
                    VendaId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Sequencial = table.Column<int>(type: "INTEGER", nullable: false),
                    ValorUnitario = table.Column<decimal>(type: "TEXT", nullable: false),
                    Quantidade = table.Column<decimal>(type: "TEXT", nullable: false),
                    PercentualDeDesconto = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItensDasVendas", x => new { x.ProdutoId, x.VendaId });
                    table.ForeignKey(
                        name: "FK_ItensDasVendas_Vendas_VendaId",
                        column: x => x.VendaId,
                        principalTable: "Vendas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItensDasVendas_VendaId",
                table: "ItensDasVendas",
                column: "VendaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItensDasVendas");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Vendas");
        }
    }
}
