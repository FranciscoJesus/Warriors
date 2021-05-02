using Exercise.Warriors.Players;
using Exercise.Warriors.Test.DataInitializer;
using Xunit;

namespace Exercise.Warriors.Test
{
    public class WarriorTest
    {
        [Theory]
        [MemberData(nameof(WarriorGenerator.GetWarriors), MemberType = typeof(WarriorGenerator))]
        public void TestWarriorKick(Warrior warrior)
        {
            warrior.Kick();
        }

        [Theory]
        [MemberData(nameof(WarriorGenerator.GetWarriors), MemberType = typeof(WarriorGenerator))]
        public void TestWarriorPunch(Warrior warrior)
        {
            warrior.Punch();
        }

        [Theory]
        [MemberData(nameof(WarriorGenerator.GetWarriors), MemberType = typeof(WarriorGenerator))]
        public void TestWarriorMove(Warrior warrior)
        {
            warrior.ShowYourMove();
        }

        [Theory]
        [MemberData(nameof(WarriorGenerator.GetWarriors), MemberType = typeof(WarriorGenerator))]
        public void TestWarriorInfected(Warrior warrior)
        {
            warrior.GetInfected();
            warrior.ShowYourMove();
        }
    }
}
