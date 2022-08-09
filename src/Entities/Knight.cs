using System;

namespace dotnet___poo.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType, int HealthPoints, int MagicPoints)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HealthPoints = HealthPoints;
            this.MaxHealthPoints = HealthPoints;
            this.MagicPoints = MagicPoints;
            this.MaxMagicPoints = MagicPoints;
            listHeroes.Add(this);
        }

        public override string Attack(Hero hero)
        {
            if (hero.HealthPoints > 0)
            {
                return $"{this.Name} atacou {hero.Name} com sua lança {TakeDamage(hero)}";
            }
            else
            {
                return TakeDamage(hero);
            }
        }
    }
}