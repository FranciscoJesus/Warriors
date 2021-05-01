using Exercise.Warriors.Players;
using System;
using System.Linq;

namespace Exercise.Warriors
{
    class Program
    {
        static void Main(string[] args)
        {
            var warriors = WarriorType.List.Select(s => s.CreatePlayer()).ToList();

            // DO NOT TOUCH THIS
            foreach (var warrior in warriors)
            {
                Console.WriteLine($"Aparece un guerrero {warrior.GetType().Name}");
                warrior.ShowYourMove();
                Console.WriteLine();
            }
            // END OF DO NOT TOUCH THIS

            warriors.ForEach(x =>
            {
                if (x.GetType() != typeof(Kangaroo))
                {
                    x.GetInfected();
                }
            });

            foreach (var warrior in warriors)
            {
                Console.WriteLine($"Aparece un guerrero {warrior.GetType().Name}");
                warrior.ShowYourMove();
                Console.WriteLine();
            }
        }
    }
}

