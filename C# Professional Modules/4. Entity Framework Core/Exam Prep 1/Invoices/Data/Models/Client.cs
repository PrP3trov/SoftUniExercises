using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Invoices.Data.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(25)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(15)]
        public string NumberVat { get; set; } = null!;

        public ICollection<Invoice> Invoices { get; set; } 
            = new HashSet<Invoice>();

        public ICollection<Address> Addresses { get; set; } 
            = new HashSet<Address>();

        public ICollection<ProductClient> ProductsClients { get; set; } 
            = new HashSet<ProductClient>();
    }
}
