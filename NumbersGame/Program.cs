using System;

namespace NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StartSequence();

            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
                
            }
        }

        static void StartSequence()
        {
            Console.WriteLine("Let's play a game with numbers!!");
            Console.WriteLine("Enter a number grater than zero:");

            // Allows user to input a number
            string firstNumberinput = Console.ReadLine();
            int firstNumberConversion = Convert.ToInt32(firstNumberinput);

            // Sets up a new array with number elements based off number user input
            int[] userArray = new int[firstNumberConversion];
            
            Populate(userArray);
            GetSum(userArray);
            GetProduct(userArray, sum);
            //GetQuotient(int);

        }

        // Populates an array of numbers chosen by the users based off number given in StartSequence
        static int[] Populate(int[] userArray)
        {
            for (int i = 0; i < userArray.Length; i++)
            {
                Console.WriteLine($"Please enter number {i+1} of {userArray.Length}");
                string populationNumberInput = Console.ReadLine();
                int populationConversion = Convert.ToInt32(populationNumberInput);
                userArray[i] = populationConversion;
            }
            return userArray;
        }

        // Gets sum of an array of numbers input by the user. 
        static int GetSum(int[] userArray)
        {
            int sum = 0;
            for (int i = 0; i < userArray.Length; i++)
            {
                sum = +userArray[i];
            }

            if (sum < 20)
            {
                throw new Exception($"Value of {sum} is too low.");
            }

            return sum;
        }

        // Gets product from random number picked by user and the sum from GetSum.
        static int GetProduct(int[] userArray, int sum )
        {
            Console.WriteLine($"Pick a number between and {userArray.Length}");
            int product;
            string randomNumber = Console.ReadLine();
            int convertRandomNumber = Convert.ToInt32(randomNumber);
            product = convertRandomNumber * sum;

            return product;
        }

    }
}
