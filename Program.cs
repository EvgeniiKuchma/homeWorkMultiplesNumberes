using System;

namespace homeWorkMultiplesNumberes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberN;
            int minValue = 10;
            int maxValue = 26;
            int startNumberRange = 50;
            int endNumberRange = 151;
            int countMultiplesNumber = 0;

            Random random = new Random();
            numberN = random.Next(minValue, maxValue);

            Console.WriteLine(numberN);
            Console.WriteLine("----------------------");

            for (int i = numberN; i < endNumberRange; i += numberN)
            {
                if (i >= startNumberRange)
                {
                    countMultiplesNumber++;
                }
            }

            Console.WriteLine(countMultiplesNumber);
        }
    }
}
