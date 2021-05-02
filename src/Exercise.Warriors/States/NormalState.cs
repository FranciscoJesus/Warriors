using Exercise.Warriors.Players;
using System;

namespace Exercise.Warriors.States
{
    public class NormalState : IState
    {
        private Warrior _warrior { get; set; }
        public NormalState(Warrior warrior)
        {
            _warrior = warrior;
        }

        public void ShowYourMove()
        {
            Console.WriteLine("Hago cosas de guerrero");
            _warrior.Punch();
            _warrior.Kick();
        }
    }
}
