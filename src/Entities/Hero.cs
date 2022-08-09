using System;
using System.Collections.Generic;

namespace dotnet___poo.src.Entities
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }
        public int HealthPoints { get; set; }
        public int MaxHealthPoints { get; set; }
        public int MagicPoints { get; set; }
        public int MaxMagicPoints { get; set; }
        public int MagicPointsMuliplier { get; set; } = 10;

        protected static List<Hero> listHeroes = new List<Hero>();

        public static void ListHeroes()
        {
            foreach (Hero item in listHeroes)
            {
                Console.WriteLine(item);
            }
        }

        public static void ListHeroesNames()
        {
            for (int i = 1; i <= listHeroes.Count; i++)
            {
                Console.WriteLine($"{i} - {listHeroes[i - 1].Name}");
            }
        }

        public virtual string TakeDamage(Hero hero)
        {
            if (hero.HealthPoints > 0)
            {
                Random rnd = new Random();

                int damage = rnd.Next(hero.HealthPoints / 10, hero.HealthPoints / 5);
                // int damage = hero.HealthPoints + 1;
                hero.HealthPoints -= damage;
                MagicPoints -= MagicPointsMuliplier;
                string str;
                if (damage > hero.HealthPoints)
                {
                    hero.HealthPoints = 0;
                    str = $"realizando o abate do oponente!";
                }
                else
                {
                    str = $"causando {damage} de dano e deixando com {hero.HealthPoints} de vida!";
                }
                return str;
            }
            else
            {
                return "Esse oponente já está morto! Escolha outro para atacar!!!";
            }

        }

        public virtual string Attack(Hero hero)
        {
            return $"{this.Name} atacou {hero.Name} com a sua arma!";
        }

        public override string ToString()
        {
            return $"\n{this.Name}  \nLv. {this.Level}  {this.HeroType} \nHP {this.HealthPoints} / {this.MaxHealthPoints} \nMP {this.MagicPoints} / {this.MaxMagicPoints}";
        }
    }
}