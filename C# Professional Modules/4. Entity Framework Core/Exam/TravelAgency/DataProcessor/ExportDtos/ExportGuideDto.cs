using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TravelAgency.DataProcessor.ExportDtos
{
    [XmlType("Guide")]
    public class ExportGuideDto
    {
        [XmlElement]
        public string FullName { get; set; }
        [XmlArray]
        public ExportTourPackagesDto[] TourPackages { get; set; }
    }
}
