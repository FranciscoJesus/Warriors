using Exercise.Warriors.Players;
using Exercise.Warriors.Players.Factory;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise.Warriors
{
    class Program
    {
        static void Main(string[] args)
        {
            // USING SMARTENUM + FACTORY PATTERN
            //var dwarf = WarriorFactory.CreatePlayer(WarriorType.Dwarf);
            //var boxer = WarriorFactory.CreatePlayer(WarriorType.Boxer);
            //var elf = WarriorFactory.CreatePlayer(WarriorType.Elf);
            //var kangaroo = WarriorFactory.CreatePlayer(WarriorType.Kangaroo);

            //var warriors = new List<Warrior> { dwarf, boxer, elf, kangaroo };

            // USING ONLY SMARTENUM
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

