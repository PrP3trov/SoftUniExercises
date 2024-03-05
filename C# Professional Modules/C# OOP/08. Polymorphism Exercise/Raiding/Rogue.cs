namespace Raiding
{
    public class Rogue : BaseHero
    {
        private const int DefaultPower = 80;

        public Rogue(string name) : base(name, DefaultPower)
        {
        }

        public override string CastAbility()
        {
            return $"{GetType().Name} - {Name} hit for {Power} damage";
        }
    }
}
