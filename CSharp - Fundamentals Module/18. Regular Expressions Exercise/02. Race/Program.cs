using System.Text;
using System.Text.RegularExpressions;
List<string> participantNames = Console.ReadLine().Split(", ").ToList();
List<Participant> participants = new List<Participant>();

foreach (string name in participantNames)
{
    Participant participant = new Participant(name);
    participants.Add(participant);
}
string input;
while ((input = Console.ReadLine()) != "end of race")
{
    StringBuilder nameBuilder = new StringBuilder();
    string lettersPatern = @"[A-Za-z]";
    foreach (Match match in Regex.Matches(input, lettersPatern))
    {
        nameBuilder.Append(match.Value);
    }
    string participantName = nameBuilder.ToString();
    uint distance = 0;
    string digitsPatern = @"\d";
    foreach (Match match in Regex.Matches(input, digitsPatern))
    {
        distance += uint.Parse(match.Value);
    }
    Participant foundParticipant = participants.FirstOrDefault(p => p.Name == participantName);
    if (foundParticipant != null)
    {
        foundParticipant.Distance += distance;
    }
}
List<Participant> FirsrtThreeParticipants = participants.OrderByDescending(p => p.Distance).Take(3).ToList();
Console.WriteLine($"1st place: {FirsrtThreeParticipants[0].Name}");
Console.WriteLine($"2nd place: {FirsrtThreeParticipants[1].Name}");
Console.WriteLine($"3rd place: {FirsrtThreeParticipants[2].Name}");


class Participant
{
    public Participant(string name)
    {
        Name = name;
    }
    public string Name { get; set; }
    public uint Distance { get; set; }
}