using System;

namespace Exercise.Warriors.Players
{
    public class Boxer : Warrior
    {
        public override void Kick()
        {
            Console.WriteLine("Boxer Kick");
        }
        public override void Punch()
        {
            Console.WriteLine("Boxer Punch");
        }
     }
}
