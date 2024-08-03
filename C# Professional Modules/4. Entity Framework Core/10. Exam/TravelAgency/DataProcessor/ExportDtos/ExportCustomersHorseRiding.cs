using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.DataProcessor.ExportDtos
{
    public class ExportCustomersHorseRiding
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public ExportBookingDto[] Bookings { get; set; }
    }
}
