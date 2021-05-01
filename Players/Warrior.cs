using Exercise.Warriors.Entities.States;
using Exercise.Warriors.Players.Movements;

namespace Exercise.Warriors.Entities
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
