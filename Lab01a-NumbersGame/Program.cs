using System;

namespace Lab01a_NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {

            GetQuotient(8);
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
        // GetProduct Method


        static decimal GetQuotient(int product)
        {
            //Prompt the user to enter a number to divide the product by. 
            //Display the current product to the user during this prompt.
            Console.WriteLine($"Enter a number to divide the {product} by");

            // Retrieve the input and divide the inputted number by the product.
            int userNum1 = Convert.ToInt32(Console.ReadLine());

            //Utilize the decimal.Divide() method to divide the product by the dividend to receive the quotient.
            decimal dividedNum = userNum1 / product;
            Console.WriteLine($"divided number is {dividedNum}");

            // Return the quotient
            return dividedNum;
            
        }

    }
}
