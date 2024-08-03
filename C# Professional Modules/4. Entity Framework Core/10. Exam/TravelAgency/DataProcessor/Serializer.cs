using Newtonsoft.Json;
using TravelAgency.Data;
using TravelAgency.Data.Models.Enums;
using TravelAgency.DataProcessor.ExportDtos;
using TravelAgency.Helper;

namespace TravelAgency.DataProcessor
{
    public class Serializer
    {
        public static string ExportGuidesWithSpanishLanguageWithAllTheirTourPackages(TravelAgencyContext context)
        {
            var guidesSpanish = context.Guides
                .Where(g => g.Language == (Language)3)
                .Select(g => new ExportGuideDto()
                {
                    FullName = g.FullName,
                    TourPackages = g.TourPackagesGuides
                                            .Select(g => new ExportTourPackagesDto()
                                            {
                                                Name = g.TourPackage.PackageName,
                                                Description = g.TourPackage.Description,
                                                Price = g.TourPackage.Price
                                            })
                                            .OrderByDescending(g => g.Price)
                                            .ThenBy(g => g.Name)
                                            .ToArray()
                })
                .OrderByDescending(g => g.TourPackages.Count())
                .ThenBy(g => g.FullName)
                .ToArray();

            return XmlSerializationHelper.Serialize(guidesSpanish, "Guides");
        }

        public static string ExportCustomersThatHaveBookedHorseRidingTourPackage(TravelAgencyContext context)
        {
            var customersHorseRiding = context.Customers
                .Where(c => c.Bookings.Any(b => b.TourPackage.PackageName == "Horse Riding Tour"))
                .Select(c => new ExportCustomersHorseRiding()
                {
                    FullName = c.FullName,
                    PhoneNumber = c.PhoneNumber,
                    Bookings = c.Bookings.Where(b => b.TourPackage.PackageName == "Horse Riding Tour")
                                .Select(b => new ExportBookingDto()
                                {
                                    TourPackageName = b.TourPackage.PackageName,
                                    Date = b.BookingDate.ToString("yyyy-MM-dd")
                                })
                                .OrderBy(b => b.Date)
                                .ToArray()
                })
                .OrderByDescending(c => c.Bookings.Count())
                .ThenBy(c => c.FullName)
                .ToArray();

            return JsonConvert.SerializeObject(customersHorseRiding);
        }
    }
}
