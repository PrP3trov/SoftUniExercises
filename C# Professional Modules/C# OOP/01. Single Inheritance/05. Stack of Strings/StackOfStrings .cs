namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty() => Count == 0;
        public void AddRange(IEnumerable<string> elements)
        {
            foreach (var element in elements)
            {
                Push(element);
            }
        }
    }
}
