using Exercise.Warriors.Players;
using Exercise.Warriors.Players.Factory;
using System.Collections.Generic;

namespace Exercise.Warriors.Test.DataInitializer
{
    public static class WarriorGenerator
    {
        public static IEnumerable<object[]> GetWarriors()
        {
            var allData = new List<object[]>
            {
                new object[]
                { 
                    WarriorFactory.CreatePlayer(WarriorType.Kangaroo),
                },
                new object[]
                {
                    WarriorFactory.CreatePlayer(WarriorType.Elf),
                },
                new object[]
                {
                    WarriorFactory.CreatePlayer(WarriorType.Dwarf),
                },
                new object[]
                {
                    WarriorFactory.CreatePlayer(WarriorType.Boxer),
                }
            };
            return allData;
        }
    }
}
