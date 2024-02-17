namespace SharkTaxonomy
{
    public class StartUp
    {
        static void Main()
        {
            Classifier classifier = new(10);

            Shark greatWhite = new("Great White", 5, "Seals", "Open Ocean");
            Shark hammerhead = new("Hammerhead", 4, "Fish", "Tropical Waters");
            Shark tiger = new("Tiger", 4, "Turtles", "Coral Reefs");
            Shark mako = new("Mako", 3, "Fish", "Open Ocean");
            Shark bull = new("Bull", 3, "Fish", "Rivers");
            Shark whale = new("Whale", 12, "Plankton", "Open Ocean");
            Shark leopard = new("Leopard", 1, "Crabs", "Shallow Waters");
            Shark goblin = new("Goblin", 4, "Deep-sea Creatures", "Deep Ocean");
            Shark thresher = new("Thresher", 6, "Fish", "Open Ocean");
            Shark blacktipReef = new("Blacktip Reef", 2, "Fish", "Coral Reefs");
            Shark oceanicWhitetip = new("Oceanic Whitetip", 3, "Fish", "Open Ocean");

            classifier.AddShark(greatWhite);
            classifier.AddShark(hammerhead);
            classifier.AddShark(tiger);
            classifier.AddShark(mako);
            classifier.AddShark(bull);
            classifier.AddShark(whale);
            classifier.AddShark(leopard);
            classifier.AddShark(goblin);
            classifier.AddShark(thresher);
            classifier.AddShark(blacktipReef);

            Console.WriteLine(classifier.GetCount);

            classifier.AddShark(oceanicWhitetip);

            Console.WriteLine(classifier.GetCount);

            classifier.RemoveShark("Blacktip Reef");

            Console.WriteLine(classifier.GetCount);

            classifier.RemoveShark("Blue");

            Console.WriteLine(classifier.GetCount);

            classifier.AddShark(oceanicWhitetip);

            Console.WriteLine(classifier.GetCount);

            Console.WriteLine(classifier.GetLargestShark());

            Console.WriteLine(classifier.GetAverageLength());

            Console.WriteLine(classifier.Report());

        }    }
}