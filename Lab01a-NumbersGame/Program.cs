using System;

namespace Lab01a_NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //Call the StartSequence() method from Main
                StartSequence();
            }
            catch (Exception e)
            {

                Console.WriteLine($"Sorry, exception caught in Main: {e.Message}");
            }
            finally
            {
                Console.WriteLine("The program is now complete.");
            }

        }


        static void StartSequence()
        {
            try
            {
                Console.WriteLine("Welcome to my game! Let's do some math!");

                // prompt the user to “Enter a number greater than zero”

                Console.WriteLine("Please enter a number greater than zero");

                // Utilize the Convert.ToInt32() method to convert the user’s input to an integer
                string userInput = Console.ReadLine();
                int userNumber = Convert.ToInt32(userInput);

                // Instantiate a new integer array that is the size the user just inputted

                int[] array = new int[userNumber];

                //Call the Populate method. arguments: integer array
                Populate(array);

                //Capture the sum by calling the GetSum method. arguments: integer array
                int sum = GetSum(array);
                
                // Capture the product by calling the GetProduct method. integer array and integer sum
                int product = GetProduct(array, sum);

                // Capture the quotient by calling the GetQuotient method. arguments: integer product
                GetQuotient(product);

                // To complete the method, output to the console the details of all these values. 
                // Make sure that your output contains the same information presented in the example. 
                //Pay attention to line breaks!
                Console.WriteLine($"Your array is size: {userInput}");

                // TODO complete the array output 
                //for (int i = 0; i < array.Length; i++){}
                //Console.WriteLine($"The numbers in the array are: ");
                Console.WriteLine($"The sum of the array is {sum}");
                Console.WriteLine($"{sum} * {product / sum} = {product}");

                //TODO complete the product / quotient = result 
                //Console.WriteLine($"{product} / {} = {}");
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


        static int[] Populate(int[] array)
        {
            // Iterate through the array and prompt the user to enter a specific number.
            for (int i = 0; i < array.Length; i++)
            {
                // Example: “Please enter a number 1 / 6” (indicate to the user what number they are inputting)
                Console.WriteLine($"Please enter a number {i + 1} / {array.Length}");

                // Utilize the Convert.ToInt32 method to convert the user’s input to an integer
                // (Remember not to directly manipulate the user’s input.Store the response into a string first).
                string userInput = Console.ReadLine();
                int arrayElement = Convert.ToInt32(userInput);

                // Add the number just inputted into the array.
                // Repeat this process until all numbers have been requested and the array is filled.
                array[i] = arrayElement;
            }
            
            //Return the populated array
            //Console.WriteLine(array[0]);
            return array;
        }

        static int GetSum(int[] array)
        {
            // Declare an integer variable named sum
            int sum = 0;

            // Iterate through the array and populate the sum variable 
            // with the sum of all the numbers together.
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            // Add the capability to throw a custom exception if the sum is less than 20, 
            // with the message “Value of { sum} is too low”. 
            //(replace { sum} with the actual sum of the variable).
            if (sum < 20)
            {
                throw new Exception($"Value of {sum} is too low");
            }

            // return the sum.
            //Console.WriteLine($"sum is: {sum}");
            return sum;
        }


        static int GetProduct(int[] array, int sum)
        {
            try
            {
            // Ask the user the select a random number between 1 and the length of the integer array.
            Console.WriteLine($"Please select a random number between 1 and {array.Length}");

            int randomNum = Convert.ToInt32(Console.ReadLine());

            // Declare a new variable named product
            int product;

            // Multiply sum by the random number index that the user selected from the array
            //(example: array[randomNumber]). Set this value to the product variable.
            product = sum * array[randomNum];

            //Console.WriteLine($"product is {product}");
            // Return the product variable.
            return product;
            }
            catch (IndexOutOfRangeException e)
            {
                //Output the message to the console.
                Console.WriteLine(e.Message);

                //throw it back down the callstack so that it displays within Main
                throw;
            }
        }


        static decimal GetQuotient(int product)
        {
            try
            {
            //Prompt the user to enter a number to divide the product by. 
            //Display the current product to the user during this prompt.
            Console.WriteLine($"Please enter a number to divide your product {product} by");

            // Retrieve the input and divide the inputted number by the product.
            decimal inputNum1 = Convert.ToDecimal(Console.ReadLine());
            decimal dividend = Convert.ToDecimal(product) / inputNum1;

            //Utilize the decimal.Divide() method to divide the product by the dividend to receive the quotient.
            decimal quotient = decimal.Divide(product, dividend);

            //Console.WriteLine($"divided number is {dividend}");
            //Console.WriteLine($"quotient number is {quotient}");

            // Return the quotient
            return quotient;
            }
            //Expected Exceptions: Divide by Zero Exception
            catch (DivideByZeroException e)
            {
                //Output the message to the console
                Console.WriteLine("Sorry, you can't divide by zero");

                //Return 0 if the catch gets called
                return 0;
            }

        }

    }
}
