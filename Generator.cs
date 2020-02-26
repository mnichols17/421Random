using System;


namespace RandomGenerator
{
    public class Generator
    {
        public int randomInt(int seed)
        {
            var random = new Random(seed);
            return random.Next();
        }

        public decimal randomDecimal(int seed)
        {
            var random = new Random(seed);
            return Convert.ToDecimal(random.NextDouble());
        }

        public int randomRange(int seed, int min, int max)
        {
            var random = new Random(seed);
            return random.Next(min, max);
        }

        public decimal randomRange(int seed, decimal min, decimal max)
        {
            var random = new Random(seed);
            return Convert.ToDecimal(random.NextDouble()) * (max-min) + min;
        }

        public int[] randomIntList(int seed, int length)
        {
            int[] list = new int[length];
            for(int i = 0; i < length; i++)
            {
                var random = new Random(seed + i);
                list[i] = random.Next();
            }
            return list;
        }

        public decimal[] randomDecimalList(int seed, int length)
        {
            decimal[] list = new decimal[length];
            for (int i = 0; i < length; i++)
            {
                var random = new Random(seed + i);
                list[i] = Convert.ToDecimal(random.NextDouble());
            }
            return list;
        }


    }
}
