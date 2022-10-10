using System;
namespace Program
{
    public class Example
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to the game! It's math time!");
                StartSequence();
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong..");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Game Complete! Have great day!");
            }
        }
        public static void StartSequence()
        {
            try
            {
                Console.WriteLine("Enter a number greater than zero");
                int numHere = Convert.ToInt32(Console.ReadLine());
                int[] numArray = new int[numHere];
                numArray = Populate(numHere, numArray);
                int sum = GetSum(numArray);
                int product = GetProduct(numArray, sum);
                double quotient = GetQuotient(product)[0];
                Console.WriteLine(
                    $"Your array is {numHere} numbers long.\nThe numbers in your array are {String.Join(",", numArray)}.\nThe sum of all numbers in the array is {sum}.\nThe product of "
                );
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static int[] Populate(int numHere, int[] numArray)
        {
            try
            {
                int i;
                for (i = 0; i < numArray.Length; i++)
                {
                    Console.WriteLine($"Enter a number {i + 1}/{numArray.Length}");
                    numArray[i] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(numArray);
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            return numArray;
        }
        public static int GetSum(int[] numArray)
        {
            int sum = 0;
            sum = numArray.Sum();
            return sum;
        }
        public static int GetProduct(int[] numArray, int sum)
        {
            try
            {
                int product = 0;
                Console.WriteLine($"Pick a number 1 through {numArray.Length}");
                int multiplyNum = Convert.ToInt32(Console.ReadLine());
                product = sum * numArray[multiplyNum - 1];
                Console.WriteLine($"Product works {product}");
                return product;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static double[] GetQuotient(int product)
        {
            double quotient = 0;
            double divider = 0;
            if (divider == 0)
            {
                Console.WriteLine($"Pick a number to divide your product ({product}) by.");
                divider = Convert.ToInt32(Console.ReadLine());
                quotient = product / divider;
            }
            Console.WriteLine(quotient);
            double[] divisionParts = { quotient, divider };
            return divisionParts;
        }
    }
}