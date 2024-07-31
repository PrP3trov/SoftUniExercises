using CarDealer.Data;
using CarDealer.DTOs.Import;
using CarDealer.Models;
using Newtonsoft.Json;
using System.IO;

namespace CarDealer
{
    public class StartUp
    {
        public static void Main()
        {
            CarDealerContext context = new CarDealerContext();
            string supply = File.ReadAllText("../../../Datasets/cars.json");
            Console.WriteLine(ImportCars(context,supply));
        }

        public static string ImportSuppliers(CarDealerContext context, string inputJson)
        {
            var suppliers = JsonConvert.DeserializeObject<List<Supplier>>(inputJson);

            context.Suppliers.AddRange(suppliers);
            context.SaveChanges();

            return $"Successfully imported {suppliers.Count}.";
        }

        public static string ImportParts(CarDealerContext context, string inputJson)
        {
            var parts = JsonConvert.DeserializeObject<List<Part>>(inputJson);

            var validSuppliersIds = context.Suppliers
                .Select(s => s.Id)
                .ToArray();

            var partsWithValidSupplierIds = parts
                .Where(p => validSuppliersIds.Contains(p.SupplierId))
                .ToArray();

            context.Parts.AddRange(partsWithValidSupplierIds);
            context.SaveChanges();

            return $"Successfully imported {partsWithValidSupplierIds.Length}.";
        }

        public static string ImportCars(CarDealerContext context, string inputJson)
        {
            var carsDtos = JsonConvert.DeserializeObject<List<ImportCarDto>>(inputJson);

            var cars = new HashSet<Car>();
            var partsCars = new HashSet<PartCar>();

            foreach (var carDto in carsDtos)
            {
                var newCar = new Car()
                {
                    Make = carDto.Make,
                    Model = carDto.Model,
                    TraveledDistance = carDto.TraveledDistance
                };

                cars.Add(newCar);

                foreach (var partId in carDto.PartsId.Distinct())
                {
                    partsCars.Add(new PartCar()
                    {
                        Car = newCar,
                        PartId = partId
                    });
                }
            }

            context.Cars.AddRange(cars);
            context.PartsCars.AddRange(partsCars); 
            context.SaveChanges();

            return $"Successfully imported {cars.Count}.";
        }
    }
}