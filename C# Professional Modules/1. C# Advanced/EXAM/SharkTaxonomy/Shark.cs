namespace SharkTaxonomy
{
    public class Shark
    {
        public string Kind { get; set; }
        public int Length { get; set; }
        public string Food { get; set; }
        public string Habitat { get; set; }
        public Shark(string kind, int length, string food, string habitat)
        {
            Kind = kind;
            Length = length;
            Food = food;
            Habitat = habitat;
        }
        public override string ToString()
        {
            return $"{Kind} shark: {Length}m long.\nCould be spotted in the {Habitat}, typical menu: {Food}";
            
        }
    }
}
