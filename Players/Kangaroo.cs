using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise.Warriors.Players
{
    public class Kangaroo : Warrior
    {
        public override void Kick()
        {
            Console.WriteLine("Kangaroo Kick");
        }

        public override void Punch()
        {
            Console.WriteLine("Kangaroo Punch");
        }
    }
}
