using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Internal;
using Pdi.Full.Micro.Service.Entities.Models;
using Pdi.Full.Micro.Service.Services.Abstractions;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace Pdi.Full.Micro.Service.Services.Relatorios
{
    public class RelatorioDeVendasService : IRelatorioDeVendasService
    {
        private readonly IVendaService _vendaService;

        public RelatorioDeVendasService(IVendaService vendaService)
        {
            _vendaService = vendaService;
        }

        public async Task<byte[]> ObterAsync(CancellationToken cancellationToken)
        {
            var vendas = await _vendaService.ObterAsync(cancellationToken);
            var documento =  GerarDocumentoRelatorioBase("Relatório de vendas", vendas);
            return documento.GeneratePdf();
        }

        private static Document GerarDocumentoRelatorioBase(string tituloDoRelatorio, IEnumerable<Venda> vendas)
        {
            QuestPDF.Settings.License = LicenseType.Community;
            return Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(20));

                    page.Header()
                        .Text(tituloDoRelatorio)
                        .SemiBold()
                        .FontSize(36)
                        .FontColor(Colors.Black);
                    
                    page.Content()
                        .PaddingVertical(1, Unit.Centimetre)
                        .Table(table =>
                        {
                            // step 1
                            table.ColumnsDefinition(columns =>
                            {
                                columns.ConstantColumn(25);
                                columns.RelativeColumn(3);
                                columns.RelativeColumn();
                                columns.RelativeColumn();
                                columns.RelativeColumn();
                            });

                            // step 2
                            table.Header(header =>
                            {
                                header.Cell().Element(CellStyle).Text("#");
                                header.Cell().Element(CellStyle).Text("Product");
                                header.Cell().Element(CellStyle).AlignRight().Text("Unit price");
                                header.Cell().Element(CellStyle).AlignRight().Text("Quantity");
                                header.Cell().Element(CellStyle).AlignRight().Text("Total");

                                static IContainer CellStyle(IContainer container)
                                {
                                    return container.DefaultTextStyle(x => x.SemiBold()).PaddingVertical(5)
                                        .BorderBottom(1).BorderColor(Colors.Black);
                                }
                            });

                            // step 3
                            foreach (var item in vendas)
                            {
                                table.Cell().Element(CellStyle).Text(vendas.IndexOf(item) + 1);
                                table.Cell().Element(CellStyle).Text(item.Sequencial);
                                table.Cell().Element(CellStyle).AlignRight().Text($"{item.Sequencial}$");
                                table.Cell().Element(CellStyle).AlignRight().Text(item.DataDaVenda);
                                table.Cell().Element(CellStyle).AlignRight().Text($"{item.DataDaVenda}$");

                                static IContainer CellStyle(IContainer container)
                                {
                                    return container.BorderBottom(1).BorderColor(Colors.Grey.Lighten2)
                                        .PaddingVertical(5);
                                }
                            }
                        });

                    page.Footer()
                        .AlignRight()
                        .Text(x =>
                        {
                            x.Span("Página ");
                            x.CurrentPageNumber();
                        });
                });
            });
        }
    }
}