namespace DiceGame
{
    public static class Dice
    {
        private static readonly Random _rnd = new();
        public static int Roll()
        {
            return _rnd.Next(1, 7);
        }
    }
}