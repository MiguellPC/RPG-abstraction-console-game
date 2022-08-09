namespace dotnet___poo.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType, int HealthPoints, int MagicPoints)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HealthPoints = HealthPoints;
            this.MaxHealthPoints = HealthPoints;
            this.MagicPoints = MagicPoints;
            this.MaxMagicPoints = MagicPoints;
            this.MagicPointsMuliplier *= 10;
            listHeroes.Add(this);
        }
        public override string Attack(Hero hero)
        {
            if (hero.HealthPoints > 0)
            {
                return $"{this.Name} lançou uma magia em {hero.Name} {TakeDamage(hero)}";
            }
            else
            {
                return TakeDamage(hero);
            }
        }
    }
}