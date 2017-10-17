using System;

namespace RandomValueGenerator
{

    public class RandomHitValueGenerator
    {
        //public int[] Chance = new int[3];
        public int[] GenerateHitValues()
        {
            int[] Chance = new int[3];

            Random rnd = new Random();

            for (int i = 0; i < 3; i++)
            {
                Chance[i] = rnd.Next(0, 10);
            }


            return Chance;
        }

    }
}
