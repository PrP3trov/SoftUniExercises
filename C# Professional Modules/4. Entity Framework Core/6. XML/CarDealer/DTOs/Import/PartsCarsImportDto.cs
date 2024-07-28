using System.Xml.Serialization;

namespace CarDealer.DTOs.Import
{
    [XmlType("partId")]
    public class PartsCarsImportDto
    {
        [XmlAttribute("id")]
        public int Id { get; set; }
    }
}