namespace Raiding
{
    public class Paladin : BaseHero
    {
        private const int DefaultPower = 100;
        public Paladin(string name) : base(name, DefaultPower)
        {
        }
        public override string CastAbility()
        {
            return $"{GetType().Name} - {Name} healed for {Power}";
        }
    }
}
