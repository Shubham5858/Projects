using System;

using BowlingScoreCard;
using RandomValueGenerator;

namespace ScoreBoardUI
{
    class ScoreBoard
    {
        static void Main(string[] args)
        {
            RandomHitValueGenerator RHVG = new RandomHitValueGenerator();

            int[] HitValues = new int[3];
            Console.WriteLine("Ball is rolling");
            System.Threading.Thread.Sleep(500);
            Console.Write("*");
            System.Threading.Thread.Sleep(500);
            Console.Write("*");
            System.Threading.Thread.Sleep(500);
            Console.Write("*");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("\nThe Number of Hits in Three turns are: ");


            HitValues = RHVG.GenerateHitValues();

            for (int i = 0; i < 3; i++)
            {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Number of Hits in Turn " + (i + 1) + "  " + HitValues[i]);

            }
            BowlingScoreCalculator BSC = new BowlingScoreCalculator();
            int T = BSC.CalculateScore(HitValues);
            DisplayBoard(T);
        }


        public static void DisplayBoard(int T)
        {
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Total Score is = " + T);
        }


    }
}
