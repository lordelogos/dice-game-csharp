namespace DiceGame
{
    public class ScoreBoard
    {
        private static int PlayerScore;
        private static int AiScore;

        public static string GetScores()
        {
            return $"Player {PlayerScore} - {AiScore} AI";
        }

        public static void JudgeRound(int iPlayerScore, int iAiScore)
        {
            if (iPlayerScore > iAiScore)
            {
                PlayerScore++;
            }
            else if (iPlayerScore < iAiScore)
            {
                AiScore++;
            }
        }
    }
}