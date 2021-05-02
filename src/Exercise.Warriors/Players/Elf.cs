using System;

namespace Exercise.Warriors.Players
{
    public class Elf : Warrior
    {
        public override void Kick()
        {
            Console.WriteLine("Elf Kick");
        }

        public override void Punch()
        {
            Console.WriteLine("Elf Punch");
        }
    }
}
