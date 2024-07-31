using ProductShop.Data;
using ProductShop.DTOs.Import;
using ProductShop.Models;
using System.Xml.Serialization;

namespace ProductShop
{
    public class StartUp
    {
        public static void Main()
        {
            ProductShopContext context = new ProductShopContext();
            string importData = File.ReadAllText("../../../Datasets/categories.xml");
            Console.WriteLine(ImportCategories(context,importData));
        }

        public static string ImportUsers(ProductShopContext context, string inputXml)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(UsersImportDto[]),
                new XmlRootAttribute("Users"));

            UsersImportDto[] importDtos;
            using (var reader = new StringReader(inputXml))
            {
                importDtos = (UsersImportDto[])xmlSerializer.Deserialize(reader);
            };

            var users = importDtos
                .Select(dto => new User()
                {
                    FirstName = dto.FirstName,
                    LastName = dto.LastName,
                    Age = dto.Age,
                }).ToList();

            context.Users.AddRange(users);
            context.SaveChanges();

            return $"Successfully imported {users.Count}";
        }

        public static string ImportProducts(ProductShopContext context, string inputXml)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ProductsImportDto[]),
                new XmlRootAttribute("Products"));

            ProductsImportDto[] importDtos;
            using (var reader = new StringReader(inputXml))
            {
                importDtos = (ProductsImportDto[])xmlSerializer.Deserialize(reader);
            };

            var products = importDtos
                .Select(dto => new Product()
                {
                    Name = dto.Name,
                    Price = dto.Price,
                    SellerId = dto.SellerId,
                    BuyerId = dto.BuyerId,
                }).ToList();

            context.Products.AddRange(products);
            context.SaveChanges();

            return $"Successfully imported {products.Count}";
        }

         public static string ImportCategories(ProductShopContext context, string inputXml)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(CategoriesImportDto),
                new XmlRootAttribute("Categories"));

            CategoriesImportDto[] importDtos;
            using(var reader = new StringReader(inputXml))
            {
                importDtos = (CategoriesImportDto[])xmlSerializer.Deserialize(reader);
            }

            Category[] categories = importDtos
                .Select(dto => new Category()
                {
                    Name = dto.Name
                }).ToArray();

            context.Categories.AddRange(categories);
            context.SaveChanges();

            return $"Successfully imported {categories.Length}";
        }
    }
}