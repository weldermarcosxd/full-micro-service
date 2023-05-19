using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pdi.Full.Micro.Service.WebApi.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Sequencial = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Descricao = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    Preco = table.Column<decimal>(nullable: false),
                    QuantidadeEmEstoque = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vendas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Sequencial = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataDaVenda = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItensDasVendas",
                columns: table => new
                {
                    ProdutoId = table.Column<Guid>(nullable: false),
                    VendaId = table.Column<Guid>(nullable: false),
                    Sequencial = table.Column<int>(nullable: false),
                    ValorUnitario = table.Column<decimal>(nullable: false),
                    Quantidade = table.Column<decimal>(nullable: false),
                    PercentualDeDesconto = table.Column<decimal>(nullable: false),
                    ValorTotalDosItens = table.Column<decimal>(nullable: false)
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
