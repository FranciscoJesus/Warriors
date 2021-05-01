using Exercise.Warriors.Players;
using System;

namespace Exercise.Warriors.States
{
    public class InfectedState : IState
    {
        private Warrior _warrior { get; set; }
        public InfectedState(Warrior warrior)
        {
            _warrior = warrior;
        }

        public void ShowYourMove()
        {
            Console.WriteLine("Bite Bite!!");
        }
    }
}
