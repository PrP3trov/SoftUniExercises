using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Invoices.DataProcessor.ExportDto
{
    [XmlType("Client")]
    public class ClietsWithInvoicesDto
    {
        [XmlAttribute]
        public int InvoiceCount { get; set; }

        [XmlElement]
        public string ClientName { get; set; }

        [XmlElement]
        public string VatNumber { get; set; }

        [XmlArray]
        public ExportInvoiceDto[] Invoices { get; set; }
    }
}
