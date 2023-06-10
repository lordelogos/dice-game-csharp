// Roll a random number on dice
// Ai rolls a random number on dice
// Highest role wins
// Keep track of scores
// Keep going press any key, 'q' to exit
namespace DiceGame
{
    public class Program
    {
        public static void Main()
        {
            int playerTurn, aiTurn;
            Console.WriteLine("Welcome to Dice Game v0.0.1");
            do
            {
                Console.Write("\nPress any key to Roll the Dice");
                Console.ReadKey();

                playerTurn = Dice.Roll();
                aiTurn = Dice.Roll();

                Console.WriteLine($"\n\nYou rolled {playerTurn}");
                Console.WriteLine($"EnemyAI rolled {aiTurn}");

                ScoreBoard.JudgeRound(playerTurn, aiTurn);

                Console.WriteLine("--------------------------");
                Console.WriteLine(ScoreBoard.GetScores());
                Console.WriteLine("--------------------------");

                Console.WriteLine("\nPress any key to continue... Press Q to exit");
            }
            while (Console.ReadKey().Key != ConsoleKey.Q);
        }
    }
};