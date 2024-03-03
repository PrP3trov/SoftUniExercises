using BorderControl.Models;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Models.BorderControl borderControl = new();
            string input;
            while((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length == 2)
                {
                    Robot robot = new(tokens[1], tokens[0]);
                    borderControl.AddEntityForBorderCheck(robot);
                }
                else
                {
                    Citizen citizen = new(tokens[2], tokens[0], int.Parse(tokens[1]));
                    borderControl.AddEntityForBorderCheck(citizen);
                }
            }
            string fakeIdEndSequence = Console.ReadLine();
            var detained = borderControl.EntitiesToBeChecked.Where(e => e.Id.EndsWith(fakeIdEndSequence));
            foreach(var baseEntity in detained)
            {
                Console.WriteLine(baseEntity.Id);
            }
        }
    }
}