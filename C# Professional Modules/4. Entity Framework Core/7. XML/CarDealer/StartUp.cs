using CarDealer.Data;
using CarDealer.DTOs.Export;
using CarDealer.DTOs.Import;
using CarDealer.Models;
using Castle.Core.Resource;
using Microsoft.EntityFrameworkCore.Storage;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace CarDealer
{
    public class StartUp
    {
        public static void Main()
        {
            CarDealerContext context = new CarDealerContext();
            string suppliersXml = File.ReadAllText("../../../Datasets/sales.xml");
            Console.WriteLine(GetTotalSalesByCustomer(context));
        }

        private static string SerializeToXml<T>(T dto, string xmlRootAttribute, bool omitDeclaration = false)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T), new XmlRootAttribute(xmlRootAttribute));
            StringBuilder stringBuilder = new StringBuilder();

            XmlWriterSettings settings = new XmlWriterSettings()
            {
                OmitXmlDeclaration = omitDeclaration,
                Encoding = new UTF8Encoding(false),
                Indent = true
            };

            using(StringWriter stringWriter = new StringWriter(stringBuilder,CultureInfo.InvariantCulture))
            using(XmlWriter xmlWriter = XmlWriter.Create(stringWriter, settings))
            {
                XmlSerializerNamespaces xmlSerializerNamespaces = new XmlSerializerNamespaces();
                xmlSerializerNamespaces.Add(string.Empty, string.Empty);

                try
                {
                    xmlSerializer.Serialize(xmlWriter, dto, xmlSerializerNamespaces);
                }
                catch (Exception)
                {

                    throw;
                }

                return stringBuilder.ToString();
            }
        }

        public static string ImportSuppliers(CarDealerContext context, string inputXml)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(SupplierImportDto[]), 
                new XmlRootAttribute("Suppliers"));

            SupplierImportDto[] importDtos;
            using (var reader = new StringReader(inputXml))
            {
                importDtos = (SupplierImportDto[])xmlSerializer.Deserialize(reader);
            };

            Supplier[] suppliers = importDtos
                .Select(dto => new Supplier()
                {
                    Name = dto.Name,
                    IsImporter = dto.IsImporter
                }).ToArray();

            context.Suppliers.AddRange(suppliers);
            context.SaveChanges();

            return $"Successfully imported {suppliers.Length}";
        }

        public static string ImportParts(CarDealerContext context, string inputXml)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(PartsImportDto[]),
                 new XmlRootAttribute("Parts"));

            PartsImportDto[] importDtos;
            using (var reader = new StringReader(inputXml))
            {
                importDtos = (PartsImportDto[])xmlSerializer.Deserialize(reader);
            };

            var supplierIds = context.Suppliers
                .Select(s => s.Id)
                .ToArray();

            var partsWithValidSuppliers = importDtos
                .Where(p => supplierIds.Contains(p.SupplierId))
                .ToArray();

            Part[] parts = partsWithValidSuppliers
                .Select(dto => new Part()
                {
                    Name = dto.Name,
                    Price = dto.Price,
                    Quantity = dto.Quantity,
                    SupplierId = dto.SupplierId
                }).ToArray();

            context.Parts.AddRange(parts);
            context.SaveChanges();

            return $"Successfully imported {parts.Length}";
        }

        public static string ImportCars(CarDealerContext context, string inputXml)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(CarsImportDto[]),
                 new XmlRootAttribute("Cars"));

            CarsImportDto[] importDtos;
            using (var reader = new StringReader(inputXml))
            {
                importDtos = (CarsImportDto[])xmlSerializer.Deserialize(reader);
            };

            List<Car> cars = new List<Car>();

            foreach (var dto in importDtos)
            {
                Car car = new Car()
                {
                    Make = dto.Make,
                    Model = dto.Model,
                    TraveledDistance = dto.TraveledDistance
                };

                int[] carPartsId = dto.PartIds
                    .Select(p => p.Id)
                    .Distinct()
                    .ToArray();

                List<PartCar> carParts = new List<PartCar>();

                foreach (var id in carPartsId)
                {
                    carParts.Add(new PartCar()
                    {
                        Car = car,
                        PartId = id
                    });
                }

                car.PartsCars = carParts;
                cars.Add(car);
            }

            context.AddRange(cars);
            context.SaveChanges();

            return $"Successfully imported {cars.Count}";

        }

        public static string ImportCustomers(CarDealerContext context, string inputXml)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(CustomersImportDto[]),
                new XmlRootAttribute("Customers"));

            CustomersImportDto[] importDtos;
            using (var reader = new StringReader(inputXml))
            {
                importDtos = (CustomersImportDto[])xmlSerializer.Deserialize(reader);
            };

            Customer[] customers = importDtos
                .Select(dto => new Customer()
                {
                    Name = dto.Name,
                    BirthDate = dto.BirthDate,
                    IsYoungDriver = dto.IsYoungDriver,
                }).ToArray();

            context.Customers.AddRange(customers);
            context.SaveChanges();

            return $"Successfully imported {customers.Length}";
        }

        public static string ImportSales(CarDealerContext context, string inputXml)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(SalesImportDto[]),
                 new XmlRootAttribute("Sales"));

            SalesImportDto[] importDtos;
            using (var reader = new StringReader(inputXml))
            {
                importDtos = (SalesImportDto[])xmlSerializer.Deserialize(reader);
            };

            var carIds = context.Cars
                .Select(c => c.Id)
                .ToArray();

            var validCars = importDtos
                .Where(c => carIds.Contains(c.CarId))
                .ToArray();

            Sale[] sales = validCars
                .Select(dto => new Sale()
                {
                    CarId = dto.CarId,
                    CustomerId = dto.CustomerId,
                    Discount = dto.Discount
                })
                .ToArray();

            context.Sales.AddRange(sales);
            context.SaveChanges();

            return $"Successfully imported {sales.Length}";
        }

        public static string GetCarsWithDistance(CarDealerContext context)
        {
            var carsWithDistance = context.Cars
                .Select(c => new CarsWithDistanceExportDto()
                {
                    Make = c.Make,
                    Model = c.Model,
                    TraveledDistance = c.TraveledDistance
                })
                .OrderBy(c => c.Make)
                .ThenBy(c => c.Model)
                .Take(10)
                .ToArray();


            return SerializeToXml(carsWithDistance,"cars");
        }

        public static string GetCarsFromMakeBmw(CarDealerContext context)
        {
            var carsFromBmw = context.Cars
                .Where(c => c.Make == "BMW")
                .Select(c => new CarsFromBmwDto()
                {
                    Id = c.Id,
                    Model = c.Model,
                    TraveledDistance = c.TraveledDistance
                })
                .OrderBy(c => c.Model)
                .ThenByDescending(c => c.TraveledDistance)
                .ToArray();

            return SerializeToXml(carsFromBmw, "cars",true);
        }

        public static string GetLocalSuppliers(CarDealerContext context)
        {
            var suppliersNotFromAbroad = context.Suppliers
                .Where(s => s.IsImporter == false)
                .Select(s => new LocalSuppliersDto()
                {
                    Id = s.Id,
                    Name = s.Name,
                    PartsCount = s.Parts.Count
                })
                .ToArray();

            return SerializeToXml(suppliersNotFromAbroad, "suppliers");
        }

        public static string GetCarsWithTheirListOfParts(CarDealerContext context)
        {
            var carsWithParts = context.Cars
                .Select(c => new CarWithPartsDto()
                {
                    Make = c.Make,
                    Model = c.Model,
                    TraveledDistance = c.TraveledDistance,
                    Parts = c.PartsCars.OrderByDescending(c => c.Part.Price)
                        .Select(pc => new PartsForCarsDto()
                        {
                            Name = pc.Part.Name,
                            Price = pc.Part.Price
                        })                       
                        .ToArray()                     
                })
                .OrderByDescending(c => c.TraveledDistance)
                .ThenBy(c => c.Model)
                .Take(5)
                .ToArray();

            return SerializeToXml(carsWithParts, "cars");
        }

        public static string GetTotalSalesByCustomer(CarDealerContext context)
        {
            var temp = context.Customers
                .Where(c => c.Sales.Any())
                .Select(c => new
                {
                    FullName = c.Name,
                    BoughtCars = c.Sales.Count,
                    SalesInfo = c.Sales.Select(s => new
                    {
                        Prices = c.IsYoungDriver
                        ? s.Car.PartsCars.Sum(pc => Math.Round((double)pc.Part.Price * 0.95,2))
                        : s.Car.PartsCars.Sum(pc => (double)pc.Part.Price)
                    }).ToArray()
                }).ToArray();

            var customerSalesInfor = temp
                .OrderByDescending(x => x.SalesInfo.Sum(y => y.Prices))
                .Select(a => new CustomerExportDto()
                {
                    FullName = a.FullName,
                    CarsBought = a.BoughtCars,
                    MoneySpent = a.SalesInfo.Sum(b =>(decimal)b.Prices)
                }).ToArray();

            return SerializeToXml(customerSalesInfor, "customers");
        }
    }
}