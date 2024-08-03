namespace Invoices.DataProcessor
{
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.Text;
    using Invoices.Data;
    using Invoices.Data.Models;
    using Invoices.Data.Models.Enums;
    using Invoices.DataProcessor.ImportDto;
    using Invoices.Helper;
    using Microsoft.EntityFrameworkCore.Storage;
    using Newtonsoft.Json;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfullyImportedClients
            = "Successfully imported client {0}.";

        private const string SuccessfullyImportedInvoices
            = "Successfully imported invoice with number {0}.";

        private const string SuccessfullyImportedProducts
            = "Successfully imported product - {0} with {1} clients.";


        public static string ImportClients(InvoicesContext context, string xmlString)
        {
            StringBuilder sb = new StringBuilder();

            List<Client> clients = new List<Client>();

            var clientsDtos = XmlSerializationHelper
                    .Deserialize<ImportClientDto[]>(xmlString, "Clients");

            foreach (var dto in clientsDtos)
            {
                if (!IsValid(dto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                List<Address> addresses = new List<Address>();

                foreach (var addressDto in dto.Addresses)
                {
                    if (!IsValid(addressDto))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }
                    Address address = new Address()
                    {
                        StreetName = addressDto.StreetName,
                        StreetNumber = addressDto.StreetNumber,
                        PostCode = addressDto.PostCode,
                        City = addressDto.City,
                        Country = addressDto.Country
                    };

                    addresses.Add(address);
                }

                Client client = new Client()
                {
                    Name = dto.Name,
                    NumberVat = dto.NumberVat,
                    Addresses = addresses
                };

                clients.Add(client);
                sb.AppendLine(string.Format(SuccessfullyImportedClients, dto.Name));
            }

            context.Clients.AddRange(clients);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }


        public static string ImportInvoices(InvoicesContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();
            List<Invoice> invoices = new List<Invoice>();

            var invoicesDtos = JsonConvert
                    .DeserializeObject<ImportInvoiceDto[]>(jsonString);

            foreach (var dto in invoicesDtos)
            {
                if (!IsValid(dto))
                {
                    sb.AppendLine(ErrorMessage); 
                    continue;
                }

                bool isIssueDateValid = DateTime
                    .TryParse(dto.IssueDate, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime issueDate);

                bool isDueDateValid = DateTime
                    .TryParse(dto.DueDate, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dueDate);

                if (isIssueDateValid = false || isDueDateValid == false ||
                    DateTime.Compare(dueDate,issueDate) <0)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                if (!context.Clients.Any(cl => cl.Id == dto.ClientId))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Invoice invoice = new Invoice()
                {
                    Number = dto.Number,
                    IssueDate = issueDate,
                    DueDate = dueDate,
                    Amount = dto.Amount,
                    CurrencyType = (CurrencyType)dto.CurrencyType,
                    ClientId = dto.ClientId
                };

                invoices.Add(invoice);
                sb.AppendLine(string.Format(SuccessfullyImportedInvoices, dto.Number));
            }

            context.Invoices.AddRange(invoices);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportProducts(InvoicesContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();
            ICollection<Product> productsToImport = new List<Product>();

            ImportProductDto[] deserializedProducts = JsonConvert
                    .DeserializeObject<ImportProductDto[]>(jsonString)!;

            foreach (ImportProductDto productDto in deserializedProducts)
            {
                if (!IsValid(productDto))
                {
                    sb.AppendLine(ErrorMessage); 
                    continue;
                }

                Product newProduct = new Product()
                {
                    Name = productDto.Name,
                    Price = productDto.Price,
                    CategoryType = (CategoryType)productDto.CategoryType
                };

                ICollection<ProductClient> productClientsToImport = new List<ProductClient>();
                foreach (int clientId in productDto.Clients.Distinct())
                {
                    if (!context.Clients.Any(cl => cl.Id == clientId))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    ProductClient newProductClient = new ProductClient()
                    {
                        Product = newProduct,
                        ClientId = clientId
                    };
                    productClientsToImport.Add(newProductClient);
                }

                newProduct.ProductsClients = productClientsToImport;

                productsToImport.Add(newProduct);
                sb.AppendLine(String.Format(SuccessfullyImportedProducts, productDto.Name, productClientsToImport.Count));
            }

            context.Products.AddRange(productsToImport);
            context.SaveChanges();

            return sb.ToString();
        }

        public static bool IsValid(object dto)
        {
            var validationContext = new ValidationContext(dto);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(dto, validationContext, validationResult, true);
        }
    } 
}
