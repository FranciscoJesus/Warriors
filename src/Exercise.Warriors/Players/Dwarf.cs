using System;

namespace Exercise.Warriors.Players
{
    public class Dwarf : Warrior
    {
        public override void Kick()
        {
            Console.WriteLine("Dwarf Kick");
        }

        public override void Punch()
        {
            Console.WriteLine("Dwarf Punch");
        }
    }
}
