using System.Threading.Channels;

namespace Atelier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // First exo : 
            Console.WriteLine("[1] - Sum Addition : " + Addition(5, 5)); //  => 10


            Console.WriteLine("--------------------\n\n");

            //Second Exo : 
            var ints = new int[] { 1, 2, 3 };
            Console.WriteLine("[2] - Sum ints : " + SumInts(ints));
            ShowIntsValue(ints);

            Console.WriteLine("--------------------\n\n");

            // Third Exo : 
            var decimals = new double[] { 42.5, 85.2, 125, 80 };
            Console.WriteLine("[3] - Sum decimals : " + SumDecimals(decimals));

            Console.WriteLine("--------------------\n\n");

            // Four exo : 
            DisplayArrayOperations();
        }

        // First Exo : 
        static int Addition(int a, int b) => a + b;

        // Second Exo : 
        static int SumInts(int[] ints) => ints.Sum(x => x);



        static void ShowIntsValue(int[] ints)
        {
            foreach (int val in ints)
                Console.WriteLine(val);
        }

        // Third Exo : 
        static double SumDecimals(double[] decimals) => decimals.Sum(x => x);


        // Four Exo : 
        static void ShowSumInts(int sum) => Console.Write("[4]  - Show Sum ints : " + sum + "\n");

        static void ShowIntsValueFour(int[] ints)
        {
            Console.WriteLine("[4]  - Show Ints values : ");

            foreach (int val in ints)
                Console.WriteLine(val);
        }

        static void ShowAverageInts(int[] ints)
        {
            int average = 0;

            foreach (int val in ints)
                average += val;

            average /= ints.Length;

            Console.Write("[4] - Average : " + average);
        }

        static void DisplayArrayOperations()
        {
            ShowIntsValueFour(new int[] { 1, 2, 3 });
            ShowSumInts(SumInts(new int[] { 1, 2, 3 }));
            ShowAverageInts(new int[] { 5, 55, 42, 65, 20, 48, 100 });
        }
    }
}
