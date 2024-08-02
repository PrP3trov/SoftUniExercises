namespace Invoices.DataProcessor
{
    using Invoices.Data;
    using Invoices.DataProcessor.ExportDto;
    using Invoices.DataProcessor.ImportDto;
    using Invoices.Helper;
    using Newtonsoft.Json;
    using System.CodeDom.Compiler;
    using System.Globalization;

    public class Serializer
    {
        public static string ExportClientsWithTheirInvoices(InvoicesContext context, DateTime date)
        {
            ClietsWithInvoicesDto[] clientsToExport = context.Clients
                .Where(cl => cl.Invoices.Any(i => DateTime.Compare(i.IssueDate, date) > 0))
                .Select(cl => new ClietsWithInvoicesDto()
                {
                    ClientName = cl.Name,
                    VatNumber = cl.NumberVat,
                    Invoices = cl.Invoices
                        .OrderBy(i => i.IssueDate)
                        .ThenByDescending(i => i.DueDate)
                        .Select(i => new ExportInvoiceDto()
                        {
                            InvoiceNumber = i.Number,
                            InvoiceAmount = i.Amount,
                            Currency = i.CurrencyType.ToString(),
                            DueDate = i.DueDate.ToString("d", CultureInfo.InvariantCulture)
                        })
                        .ToArray(),
                    InvoiceCount = cl.Invoices.Count
                })
                .OrderByDescending(cl => cl.InvoiceCount)
                .ThenBy(cl => cl.ClientName)
                .ToArray();

            return XmlSerializationHelper.Serialize(clientsToExport, "Clients");
        }

        public static string ExportProductsWithMostClients(InvoicesContext context, int nameLength)
        {
            ProductsWithClientsDto[] productsToExport = context.Products
                .Where(p => p.ProductsClients.Any())
                .Where(p => p.ProductsClients.Any(pc => pc.Client.Name.Length >= nameLength))
                .Select(p => new ProductsWithClientsDto()
                {
                    Name = p.Name,
                    Price = p.Price,
                    Category = p.CategoryType.ToString(),
                    Clients = p.ProductsClients
                        .Where(pc => pc.Client.Name.Length >= nameLength)
                        .Select(pc => new ExportProductClientsDto()
                        {
                            Name = pc.Client.Name,
                            NumberVat = pc.Client.NumberVat,
                        })
                        .OrderBy(c => c.Name)
                        .ToArray()
                })
                .OrderByDescending(p => p.Clients.Length)
                .ThenBy(p => p.Name)
                .Take(5)
                .ToArray();

            return JsonConvert.SerializeObject(productsToExport, Formatting.Indented);
        }
    }
}