using System;
namespace Program{
    public class Example{
        public static void Main(string[] args){
            try{
            Console.WriteLine("Welcome to the game! It's math time!");
            StartSequence();
            }
            finally {
                Console.WriteLine("Game Complete! Have great day!");
            }
        }
        public static void StartSequence(){
            string[] numArray = new string[6];
            // probably need a for loop?
            Console.WriteLine("Enter a number greater than zero");
            int numhere = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numhere);
            GetSum();
        }
        public static void GetSum(){
            int sum = 0;
            //for ()
            Console.WriteLine($"Sum works {sum}");
            GetProduct();
        }
        public static void GetProduct(){
            int product = 0;
            Console.WriteLine($"Product works {product}");
            GetQuotient();
        }
        public static void GetQuotient(){
            int quotient = 0;
            Console.WriteLine($"Quotient works {quotient}");
        }
    }
}