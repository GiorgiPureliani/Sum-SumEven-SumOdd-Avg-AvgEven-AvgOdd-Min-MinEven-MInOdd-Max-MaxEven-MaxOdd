namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[10];

            int sumEven = 0, sumOdd = 0;
            int counterEven = 0, counterOdd = 0;
            int? minEven = null, maxEven = null, minOdd = null, maxOdd = null;
            double avgEven, avgOdd;

            for (int i = 0; i < x.Length; i++)
            {
                x[i] = Random.Shared.Next(2, 3);
                Console.Write($"X[{i}] = {x[i]} ");

                if (x[i] % 2 == 0)
                {
                    Console.WriteLine("even");
                    sumEven += x[i];
                    counterEven++;
                    minEven = maxEven = x[i];
                }
                else
                {
                    Console.WriteLine("odd");
                    sumOdd += x[i];
                    counterOdd++;
                    minOdd = maxOdd = x[i];
                }
            }

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] % 2 == 0)
                {
                    if (minEven > x[i])
                    {
                        minEven = x[i];
                    }

                    if (maxEven < x[i])
                    {
                        maxEven = x[i];
                    }
                }

                else
                {
                    if (minOdd > x[i])
                    {
                        minOdd = x[i];
                    }

                    if (maxOdd < x[i])
                    {
                        maxOdd = x[i];
                    }
                }
            }

            avgEven = (double)sumEven / counterEven;
            avgOdd = (double)sumOdd / counterOdd;

            Console.WriteLine($"\nsum of even numbers = {sumEven}");
            Console.WriteLine($"sum of odd numbers = {sumOdd}");
            Console.WriteLine($"\nAverage of even numbers = {avgEven}");
            Console.WriteLine($"Average of odd numbers = {avgOdd}");
            Console.WriteLine($"\nMin of even numbers = {minEven}");
            Console.WriteLine($"Max of even numbers = {maxEven}");
            Console.WriteLine($"\nMin of odd numbers = {minOdd}");
            Console.WriteLine($"Max of odd numbers = {maxOdd}");
        }
    }
}