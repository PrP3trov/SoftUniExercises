namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private Random rnd;

        public RandomList(Random rnd)
        {
            this.rnd = rnd;
        }

        public string RandomString()
        {
            int index = rnd.Next(0,Count);
            string str = this[index];
            this.RemoveAt(index);
            return str;
        }
    }
}
