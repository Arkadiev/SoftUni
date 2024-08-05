using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;
using TravelAgency.Data;
using TravelAgency.Data.Models;
using TravelAgency.DataProcessor.ImportDtos;
using TravelAgency.Helper;
using System.Globalization;

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

            XmlHelper helper = new XmlHelper();
            const string xmlRoot = "Customer";

            ICollection<Customer> customersToImport = new List<Customer>();

            ImportCustomerDto[] deserializedCustomers = helper.Deserialize<ImportCustomerDto[]>(xmlString, "Customers");

            foreach (ImportCustomerDto dto in deserializedCustomers)
            {
                if (!IsValid(dto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Customer newCustomer = new Customer()
                {
                    FullName = dto.FullName,
                    Email = dto.Email,
                    PhoneNumber = dto.PhoneNumber
                };

                if (customersToImport.Any(c => c.FullName == newCustomer.FullName)
                    || customersToImport.Any(c => c.Email == newCustomer.Email)
                    || customersToImport.Any(c => c.PhoneNumber == newCustomer.PhoneNumber))
                {
                    sb.AppendLine(DuplicationDataMessage);
                    continue;
                }

                customersToImport.Add(newCustomer);
                sb.AppendLine(String.Format(SuccessfullyImportedCustomer, dto.FullName));
            }

            context.Customers.AddRange(customersToImport);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportBookings(TravelAgencyContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();
            ICollection<Booking> bookingsToImport = new List<Booking>();

            ImportBookingDto[] deserializedBookings = JsonConvert.DeserializeObject<ImportBookingDto[]>(jsonString);

            foreach (ImportBookingDto dto in deserializedBookings)
            {
                if (!IsValid(dto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                bool isBookingDateValid = DateTime
                    .TryParseExact(dto.BookingDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime bookingDate);

                if (isBookingDateValid == false)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Customer customer = context.Customers.SingleOrDefault(c => c.FullName == dto.CustomerName);

                TourPackage package = context.TourPackages.SingleOrDefault(p => p.PackageName == dto.TourPackageName);

                if (customer == null || package == null)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                if (context.Bookings.Any(b => b.CustomerId == customer.Id && b.TourPackageId == package.Id && b.BookingDate == bookingDate))
                {
                    sb.AppendLine(DuplicationDataMessage);
                    continue;
                }

                Booking booking = new Booking()
                {
                    BookingDate = bookingDate,
                    CustomerId = customer.Id,
                    TourPackageId = package.Id
                };

                context.Bookings.Add(booking);
                context.SaveChanges();

                sb.AppendLine(String.Format(SuccessfullyImportedBooking, dto.TourPackageName, bookingDate.ToString("yyyy-MM-dd")));
            }

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