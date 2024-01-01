using Microsoft.EntityFrameworkCore.Metadata.Internal;
using QuestPDF.Drawing;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace MechanicalWorkshop.Api.Pdf
{
    public class InvoiceDocument : IDocument
    {
        public InvoiceModel Model { get; }

        public InvoiceDocument(InvoiceModel model)
        {
            this.Model = model;
        }

        public void Compose(IDocumentContainer container)
        {
            container
                .Page(page =>
                {
                    page.Margin(50);

                    page.Header().AlignLeft().Text(x =>
                    {
                        x.Line("Faktura nr 717").Bold().FontSize(20);
                        x.Line($"Data wygenerowania: {DateTime.Now.ToShortDateString()}").FontSize(14);
                        x.Line("Marcin Dajer").FontSize(12);
                        x.Line("Warsztat Mechaniczny - XXX").FontSize(12);
                    });
                    page.Content().Table(ComposeContent);
                    page.Footer().AlignCenter().Text(x =>
                    {
                        x.CurrentPageNumber();
                        x.Span(" / ");
                        x.TotalPages();
                    });
                });
        }

        public DocumentMetadata GetMetadata()
        {
            return new DocumentMetadata();
        }

        private void ComposeContent(TableDescriptor table)
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
                header.Cell().Element(CellStyle).Text("Produkt");
                header.Cell().Element(CellStyle).AlignRight().Text("Cena za szt.");
                header.Cell().Element(CellStyle).AlignRight().Text("Ilość");
                header.Cell().Element(CellStyle).AlignRight().Text("Suma");

                static IContainer CellStyle(IContainer container)
                {
                    return container.DefaultTextStyle(x => x.SemiBold()).PaddingVertical(5).BorderBottom(1).BorderColor(Colors.Black);
                }
            });

            // step 3
            foreach (var part in Model.Parts)
            {
                table.Cell().Element(CellStyle).Text(Model.Parts.IndexOf(part) + 1);
                table.Cell().Element(CellStyle).Text(part.PartName);
                table.Cell().Element(CellStyle).AlignRight().Text($"{part.PricePerUnit} PLN");
                table.Cell().Element(CellStyle).AlignRight().Text(part.Quantity);
                table.Cell().Element(CellStyle).AlignRight().Text($"{part.TotalPrice} PLN");

                static IContainer CellStyle(IContainer container)
                {
                    return container.BorderBottom(1).BorderColor(Colors.Grey.Lighten2).PaddingVertical(5);
                }
            };

            table.Cell().ColumnSpan(5).Element(GrandTotalStyle).Text($"Razem: {Math.Round(Model.GrandTotal, 2)} PLN");

            table.Cell().ColumnSpan(5).Element(HintsStyle).Text($"Wskazówka serwisu: {Model.Hint}");
            
            static IContainer GrandTotalStyle(IContainer container)
            {
                return container.DefaultTextStyle(x => x.FontSize(16)).AlignRight();
            }

            static IContainer HintsStyle(IContainer container)
            {
                return container.DefaultTextStyle(x => x.FontSize(14)).AlignLeft().PaddingTop(30);
            }
        }
    }
}
