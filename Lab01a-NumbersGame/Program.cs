using System;

namespace Lab01a_NumbersGame
{
    /// <summary>
    /// This method the StartSequence() method 
    /// </summary>
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
                Console.WriteLine($"An exception in Main has been caught");

                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("The program is now complete.");
            }

        }

        /// <summary>
        /// This method prompt the user to enter a number greater than zero
        /// Utilizes the Convert.ToInt32() method to convert the user’s input to an integer
        /// Instantiates a new integer array that is the size the user just inputted
        /// Calls the Populate method, arguments: integer array
        /// Capture the sum by calling the GetSum method. arguments: integer array
        /// Capture the product by calling the GetProduct method. integer array and integer sum
        /// Capture the quotient by calling the GetQuotient method. arguments: integer product
        /// Outputs to the console the details of all these values.
        /// </summary>
        static void StartSequence()
        {
            try
            {
                Console.WriteLine("Welcome to my game! Let's do some math!");
                Console.WriteLine("Please enter a number greater than zero");

                string userInput = Console.ReadLine();
                int userNumber = Convert.ToInt32(userInput);

                int[] numbersArray = new int[userNumber];
                numbersArray = Populate(numbersArray);

                int sum = GetSum(numbersArray);
                
                int product = GetProduct(numbersArray, sum);

                decimal quotient = GetQuotient(product);

                Console.WriteLine($"Your array is size: {userInput}");
                Console.WriteLine($"The numbers in the array are: {string.Join(',', numbersArray)}");
                Console.WriteLine($"The sum of the array is {sum}");
                Console.WriteLine($"{sum} * {product / sum} = {product}");
                Console.WriteLine($"{product} / {product / quotient} = {quotient}");
            }
            catch(FormatException e)
            {
                Console.WriteLine($"Exception caught in Main: {e.Message}");
            }
            catch(OverflowException e)
            {
                Console.WriteLine($"Exception caught in Main: {e.Message}");
            }

        }

        /// <summary>
        /// This method iterates through the array and prompt the user to enter a specific number
        /// Utilizes the Convert.ToInt32 method to convert the user’s input to an integer
        /// Add the number just inputted into the array
        /// Repeat this process until all numbers have been requested and the array is filled
        /// Return the populated array
        /// </summary>
        /// <param name="array">An int array</param>
        /// <returns>an int array</returns>
        static int[] Populate(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Please enter a number {i + 1} / {array.Length}");

                string userInput = Console.ReadLine();
                int arrayElement = Convert.ToInt32(userInput);

                array[i] = arrayElement;
            }
            
            return array;
        }

        /// <summary>
        /// This method declares an integer variable named sum
        /// Iterates through the array and populates the sum variable with the sum of all the numbers together
        /// Returns the sum
        /// It has the capability to throw a custom exception if the sum is less than 20
        /// </summary>
        /// <param name="array">An int array</param>
        /// <returns>An int</returns>
        static int GetSum(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            if (sum < 20)
            {
                throw new Exception($"Value of {sum} is too low");
            }

            return sum;
        }

        /// <summary>
        /// This method asks the user the select a random number between 1 and the length of the integer array
        /// Multiplies sum by the random number index that the user selected from the array
        /// Return the product variable.
        /// </summary>
        /// <param name="array">An int array</param>
        /// <param name="sum">An int</param>
        /// <returns>An int</returns>
        static int GetProduct(int[] array, int sum)
        {
            try
            {
                Console.WriteLine($"Please select a random number between 1 and {array.Length}");

                int randomNum = Convert.ToInt32(Console.ReadLine());

                int product;

                product = sum * array[randomNum];

                return product;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);

                throw;
            }
        }

        /// <summary>
        /// This method prompts the user to enter a number to divide the product by
        /// Retrieves the input and divides the inputted number by the product.
        /// Utilizes the decimal.Divide() method to divide the product by the dividend to receive the quotient.
        /// Returns the quotient
        /// </summary>
        /// <param name="product">An int</param>
        /// <returns>A decimal</returns>
        static decimal GetQuotient(int product)
        {
            try
            {
                Console.WriteLine($"Please enter a number to divide your product {product} by");

                decimal inputNum1 = Convert.ToDecimal(Console.ReadLine());
                decimal dividend = Convert.ToDecimal(product) / inputNum1;

                decimal quotient = decimal.Divide(product, dividend);

                return quotient;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Sorry, you can't divide by zero");

                return 0;
            }

        }

    }
}
