using Exercise.Warriors.Players.Movements;
using Exercise.Warriors.States;

namespace Exercise.Warriors.Players
{
    public abstract class Warrior : IKick, IPunch
    {
        protected IState _state;

        protected Warrior()
        {
            _state = new NormalState(this);
        }

        public void ShowYourMove()
        {
            _state.ShowYourMove();
        }

        public void GetInfected()
        {
            _state = new InfectedState(this);
        }

        public abstract void Punch();

        public abstract void Kick();
    }
}
