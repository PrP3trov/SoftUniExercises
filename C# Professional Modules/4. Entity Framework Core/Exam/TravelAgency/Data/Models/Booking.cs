using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Data.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime BookingDate { get; set; }

        [Required]
        [ForeignKey(nameof(Customer))]
        public int CustomerId  { get; set; }

        public Customer Customer { get; set; }

        [Required]
        [ForeignKey(nameof(TourPackage))]
        public int TourPackageId  { get; set; }

        public TourPackage TourPackage { get; set; }
    }
}
