using Exercise.Warriors.Entities.States;
using System;

namespace Exercise.Warriors.Entities
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
