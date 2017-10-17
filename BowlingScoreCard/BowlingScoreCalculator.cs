namespace BowlingScoreCard
{
    public class BowlingScoreCalculator

    {
        public int CalculateScore(int[] HitValues)
        {

            int[] Score = new int[3];
            int TotalScore = 0;


            for (int i = 0; i < 3; i++)
            {
                if (HitValues[i] > 6 && HitValues[i] < 9)
                {
                    Score[i] = 2;

                }

                else if (HitValues[i] > 0 && HitValues[i] < 7)
                {
                    Score[i] = 1;

                }
            }

            if (HitValues[0] == 9)
            {
                TotalScore = TotalScore + 10;

            }
            else if (HitValues[0] != 9 && HitValues[1] == 9)
            {
                TotalScore = TotalScore + 7;
                TotalScore = TotalScore + Score[0];
            }
            else if (HitValues[0] != 9 && HitValues[1] != 9 && HitValues[2] == 9)
            {
                TotalScore = TotalScore + 4;
                TotalScore = TotalScore + Score[0] + Score[1];
            }
            else
            {
                TotalScore = Score[0] + Score[1] + Score[2];
            }

            return TotalScore;
        }

    }
}

