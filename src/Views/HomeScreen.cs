using System;
using dotnet___poo.src.Entities;

namespace dotnet___poo.src.Views
{
    public static class HomeScreen
    {
        public static void PrintaTela()
        {
            Knight arus = new Knight("Arus", 42, "Knight", 749, 72);
            Ninja wedge = new Ninja("Wedge", 42, "Ninja", 574, 89);
            Wizard jenica = new Wizard("Jenica", 42, "White Wizard", 601, 482);
            Wizard topapa = new Wizard("Topapa", 42, "Black Wizard", 385, 641);
            
            Hero.ListHeroes();

            Console.WriteLine();
            Console.WriteLine(arus.Attack(wedge));
            Console.WriteLine(wedge.Attack(jenica));
            Console.WriteLine(jenica.Attack(topapa));
            Console.WriteLine(topapa.Attack(arus));

            Hero.ListHeroes();
        }
    }
}