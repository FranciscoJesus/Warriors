using Exercise.Warriors.Entities;
using System;
using System.Collections.Generic;

namespace Exercise.Warriors
{
    class Program
    {
        static void Main(string[] args)
        {
            var dwarf = new Dwarf();
            var boxer = new Boxer();
            var elf = new Elf();
            var kangaroo = new Kangaroo();

            var warriors = new List<Warrior> { dwarf, boxer, elf, kangaroo };

            // DO NOT TOUCH THIS
            foreach (var warrior in warriors)
            {
                Console.WriteLine($"Aparece un guerrero {warrior.GetType().Name}");
                warrior.ShowYourMove();
                Console.WriteLine();
            }
            // END OF DO NOT TOUCH THIS

            dwarf.GetInfected();
            boxer.GetInfected();
            elf.GetInfected();

            foreach (var warrior in warriors)
            {
                Console.WriteLine($"Aparece un guerrero {warrior.GetType().Name}");
                warrior.ShowYourMove();
                Console.WriteLine();
            }
        }
    }
}

