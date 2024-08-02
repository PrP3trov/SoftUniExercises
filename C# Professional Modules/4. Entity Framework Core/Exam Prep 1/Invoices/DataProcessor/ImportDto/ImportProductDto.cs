using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices.DataProcessor.ImportDto
{
    public class ImportProductDto
    {
        [Required]
        [MinLength(9)]
        [MaxLength(30)]
        public string Name { get; set; } = null!;

        [Required]
        [Range(typeof(decimal), "5", "1000")]
        public decimal Price { get; set; }

        [Required]
        [Range(0, 4)]
        public int CategoryType { get; set; }

        public int[] Clients { get; set; } = null!;
    }
}
