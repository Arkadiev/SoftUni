using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.DataProcessor.ExportDtos
{
    public class ExportCustomerBookingDto
    {
        public DateTime Date { get; set; }

        public string TourPackageName { get; set; } = null!;
    }
}