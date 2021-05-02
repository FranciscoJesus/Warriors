namespace Exercise.Warriors.Players.Factory
{
    public static class WarriorFactory
    {
        public static Warrior CreatePlayer(WarriorType playerType)
        {
            return playerType.CreatePlayer();
        }
    }
}
