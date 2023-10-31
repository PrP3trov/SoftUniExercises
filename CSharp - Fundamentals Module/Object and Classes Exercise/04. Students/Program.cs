class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public float Grade { get; set; }
    public override string ToString()
    {
        return $"{FirstName} {LastName} {Grade:F2}";
    }
}
class Program
{
    static void Main()
    {
        int studentCount = int.Parse(Console.ReadLine());
        List<Student> students = new List<Student>();
        for (int i = 0; i < studentCount; i++)
        {
            string[] studentAges = Console.ReadLine().Split().ToArray();
            Student student = new Student();
            student.FirstName = studentAges[0];
            student.LastName = studentAges[1];
            student.Grade = float.Parse(studentAges[2]);
            students.Add(student);
        }
        students = students.OrderByDescending(student => student.Grade).ToList();
        Console.WriteLine(string.Join("\n", students));
    }
}