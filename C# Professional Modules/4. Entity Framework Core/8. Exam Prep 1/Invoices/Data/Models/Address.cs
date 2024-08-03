using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices.Data.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string StreetName { get; set; } = null!;

        [Required]
        public int StreetNumber  { get; set; }

        [Required]
        public string PostCode { get; set; } = null!;

        [Required]
        [MaxLength(15)]
        public string City  { get; set; } = null!;

        [Required]
        [MaxLength(15)]
        public string Country  { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Client))]
        public int ClientId  { get; set; }

        public Client Client  { get; set; }

    }
}
