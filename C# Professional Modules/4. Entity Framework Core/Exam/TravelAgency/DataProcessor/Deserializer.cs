using Castle.Core.Resource;
using Microsoft.EntityFrameworkCore.Storage;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;
using System.Xml.Serialization;
using TravelAgency.Data;
using TravelAgency.Data.Models;
using TravelAgency.DataProcessor.ImportDtos;
using TravelAgency.Helper;

namespace TravelAgency.DataProcessor
{
    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data format!";
        private const string DuplicationDataMessage = "Error! Data duplicated.";
        private const string SuccessfullyImportedCustomer = "Successfully imported customer - {0}";
        private const string SuccessfullyImportedBooking = "Successfully imported booking. TourPackage: {0}, Date: {1}";

        public static string ImportCustomers(TravelAgencyContext context, string xmlString)
        {
            StringBuilder sb = new StringBuilder();
            List<Customer> customers = new List<Customer>();

            var customersDtos = XmlSerializationHelper
                .Deserialize<ImportCustomerDto[]>(xmlString, "Customers");

            foreach (var customerDto in customersDtos)
            {
                if (!IsValid(customerDto))
                {
                    sb.AppendLine(ErrorMessage); 
                    continue;
                }

                bool exists = customers.Any(c =>
                    c.FullName == customerDto.FullName ||
                    c.Email == customerDto.Email ||
                    c.PhoneNumber == customerDto.phoneNumber);

                if (exists)
                {
                    sb.AppendLine(DuplicationDataMessage);
                    continue;
                }

                Customer newCustomer = new Customer()
                {
                    FullName = customerDto.FullName,
                    Email = customerDto.Email,
                    PhoneNumber = customerDto.phoneNumber
                };

                customers.Add(newCustomer);
                sb.AppendLine(string.Format(SuccessfullyImportedCustomer, newCustomer.FullName));
            }
            context.Customers.AddRange(customers);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportBookings(TravelAgencyContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();

            var bookingDtos = JsonConvert
                .DeserializeObject<ImportBookingDto[]>(jsonString);

            List<Booking> bookings = new List<Booking>();

            foreach (var dto in bookingDtos)
            {

                bool isValidDate = DateTime.TryParseExact(dto.BookingDate, "yyyy-MM-dd", CultureInfo.InvariantCulture,
                     DateTimeStyles.None, out DateTime bookingDate);

                if (!isValidDate)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                if (!context.Customers.Any(c => c.FullName == dto.CustomerName) ||
                    !context.TourPackages.Any(t => t.PackageName == dto.TourPackageName))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Booking booking = new Booking()
                {
                    BookingDate = bookingDate,
                    Customer = context.Customers.FirstOrDefault(c => c.FullName == dto.CustomerName),
                    TourPackage = context.TourPackages.FirstOrDefault(c => c.PackageName == dto.TourPackageName)
                };

                bookings.Add(booking);
                sb.AppendLine(String.Format(SuccessfullyImportedBooking, booking.TourPackage.PackageName, booking.BookingDate.ToString("yyyy-MM-dd")));
            }

            context.Bookings.AddRange(bookings);
            context.SaveChanges();

            return sb.ToString().TrimEnd();

        }

        public static bool IsValid(object dto)
        {
            var validateContext = new ValidationContext(dto);
            var validationResults = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(dto, validateContext, validationResults, true);

            foreach (var validationResult in validationResults)
            {
                string currValidationMessage = validationResult.ErrorMessage;
            }

            return isValid;
        }
    }
}
