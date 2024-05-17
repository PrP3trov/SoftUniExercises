using System.Text;

namespace SharkTaxonomy
{
    public class Classifier
    {
        public Classifier(int capacity)
        {
            Capacity = capacity;
            Species = new List<Shark>();
        }

        public int Capacity { get; set; }
        public List<Shark> Species { get; set; }
        public int GetCount => Species.Count;
        public void AddShark(Shark shark)
        {
            if (Species.Any(x => x.Kind == shark.Kind))
                return;

            if (Species.Count < Capacity)
                Species.Add(shark);
        }
        public bool RemoveShark(string kind)
        {
            var sharkToRemove = Species.FirstOrDefault(s => s.Kind == kind);
            if (sharkToRemove == null)
                return false;
            else
            {
                    Species.Remove(sharkToRemove);
                    return true;
            }
        }
        public string GetLargestShark()
        {
            var largestShark = Species.OrderByDescending(s => s.Length).FirstOrDefault();
            return largestShark.ToString();
        }
        public double GetAverageLength()
        {
            if (Species.Count == 0)
                return 0;

            return Species.Average(s => s.Length);
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Species.Count} sharks classified:");
            foreach (var shark in Species)
            {
                sb.AppendLine($"{shark.ToString()}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
