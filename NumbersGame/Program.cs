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
            finally
            {
                Console.WriteLine("Completed game!");
            }
        }

        static void StartSequence()
        {
            Console.WriteLine("Let's play a game with numbers!!");
            Console.WriteLine("Enter a number greater than zero:");

            // Allows user to input a number
            string firstNumberinput = Console.ReadLine();
            int firstNumberConversion = Convert.ToInt32(firstNumberinput);

            // Sets up a new array with number elements based off number user input
            int[] userArray = new int[firstNumberConversion];
            
            Populate(userArray);
            // Sets variables to be used by following methods base on output of called method.
            int sum =  GetSum(userArray);
            int product = GetProduct(userArray, sum);
            Convert.ToDecimal(product);
            GetQuotient(product);

        }

        // Populates an array of numbers chosen by the users based off number given in StartSequence
        static int[] Populate(int[] userArray)
        {
            // Allows user to input integer elements
            for (int i = 0; i < userArray.Length; i++)
            {
                Console.WriteLine($"Please enter number {i+1} of {userArray.Length}");
                string populationNumberInput = Console.ReadLine();
                int populationConversion = Convert.ToInt32(populationNumberInput);
                // Sets the current position of the array to the user input.
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
                // Migrates though the array summing elements each iteration
                sum += userArray[i];
            }

            // Throws users an exception if their sum is below 20
            if (sum < 20)
            {
                throw new Exception($"Value of {sum} is too low.");
            }

            Console.WriteLine($"The sum of your numbers is {sum}");
            return sum;
        }

        // Gets product from random number picked by user and the sum from GetSum.
        static int GetProduct(int[] userArray, int sum)
        {
            Console.WriteLine($"Pick a number between 1 and {userArray.Length}");
            int product;
            string randomNumber = Console.ReadLine();
            int convertRandomNumber = Convert.ToInt32(randomNumber);

            // Checks to see if user input is within range
            if (convertRandomNumber > userArray.Length || convertRandomNumber < 1)
            {
                throw new IndexOutOfRangeException();
            }

            // Take random number provided by user and multiplies it by sum from GetSum
            product = convertRandomNumber * sum;

            Console.WriteLine($"The value of {sum} * {convertRandomNumber} is {product}.");
            return product;
        }

        // Gets Quotient of product from GetProduct and random user number input
        static decimal GetQuotient(decimal product)
        {
            // Asks the user to input a number to divide the previous product by
            Console.WriteLine($"Enter a number to divide {product} by");
            string divisor = Console.ReadLine();
            decimal decimalConversionProduct = Convert.ToDecimal(product);

            // Converts users number to a decimal value type
            decimal convertDivisor = Convert.ToDecimal(divisor);

            // Sets initial value for output
            decimal quotient = 0;

            try
            {
                quotient = decimal.Divide(decimalConversionProduct, convertDivisor);
                Console.WriteLine($"The value of {decimalConversionProduct}/{convertDivisor} is {quotient}");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            return quotient;
        }
    }
}
