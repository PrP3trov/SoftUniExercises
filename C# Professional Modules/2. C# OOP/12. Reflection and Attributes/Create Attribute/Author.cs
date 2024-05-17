namespace Create_Attribute
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class Author : Attribute
    {
        public Author(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
    }
}
