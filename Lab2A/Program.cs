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
            Console.WriteLine("Enter a number greater than zero");
            // Getting length of array
            int length = Console.ReadLine();
            try{
            int[] inputArray = new int[length];
            //Exception for if the input is invalid
            } catch (Exception e){
                Console.WriteLine(e.Message);
            }
            // Calling the next method
            Populate(inputArray);
        }
        public static int[] Populate(int[]){
            int i;
            for (i=0; i<int[].length; i++){
                Console.WriteLine($"Enter number {i+1} of {inputArray.length}");
                string input = Console.ReadLine();
                inputArray[i] = input;
            }
            GetSum(inputArray)
        }
        public static void GetSum(array){
            int sum = 0;
            int i;
            //Creating a loop to add all 
            for (i=0; i<array.length; i++){
                sum = sum + Convert.ToInt32(array[i]);
            }
            GetProduct(sum);
        }
        public static void GetProduct(sum, ){
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