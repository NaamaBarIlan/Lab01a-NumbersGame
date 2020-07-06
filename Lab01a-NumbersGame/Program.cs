using System;

namespace Lab01a_NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {

            //GetQuotient(8);
            int[] myArray = { 1, 3, 5 };
            try
            {
                GetProduct(myArray, 2);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception caught in Main: {e.Message}");
            }
            /*
            try
            {
                // The logic within this method should:
                Call the StartSequence() method from Main


                StartSequence();
            }
            catch (Exception e)
            {

                Console.WriteLine($"Sorry, exception caught in Main: {e.Message}");
            }
            finally
            {
                Console.WriteLine("The program is now complete");
            }
            */

        }

        /*
        static void StartSequence()
        {
            Console.WriteLine("Enter a number greater than zero");

            int userInput = Convert.ToInt32(Console.ReadLine());

            int[] myArray = new int[userInput];

           
        }
        */

        //static int Populate(int )

        // GetSum Method


        static int GetProduct(int[] array, int sum)
        {
            try
            {
            // Ask the user the select a random number between 1 and the length of the integer array.
            Console.WriteLine($"Select a random number between 1 and {array.Length}");

            int randomNum = Convert.ToInt32(Console.ReadLine());

            // Declare a new variable named product
            int product;

            // Multiply sum by the random number index that the user selected from the array
            //(example: array[randomNumber]). Set this value to the product variable.
            product = sum * array[randomNum];

            Console.WriteLine($"product is {product}");
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
            Console.WriteLine($"Enter a number to divide the {product} by");

            // Retrieve the input and divide the inputted number by the product.
            decimal inputNum1 = Convert.ToDecimal(Console.ReadLine());
            decimal dividend = Convert.ToDecimal(product) / inputNum1;

            //Utilize the decimal.Divide() method to divide the product by the dividend to receive the quotient.
            decimal quotient = decimal.Divide(product, dividend);

            Console.WriteLine($"divided number is {dividend}");
            Console.WriteLine($"quotient number is {quotient}");

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
