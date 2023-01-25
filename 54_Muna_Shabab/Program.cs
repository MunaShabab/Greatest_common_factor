using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// chapter 5-6 54
//wwritten by: Muna Shabab
//Date: 9-27-2020

namespace _54_Muna_Shabab
{
    class Program
    {
        static void Main(string[] args)
        {
            //explain the purpose of the program
            Console.WriteLine("This program will calculate the greatest common factor of two integers");

            //declare the variables
            int number1;
            int number2;
            int absoluteNum1;
            int absoluteNum2;
            string input;
            int GCF;
            bool GCFfound = false;

            // prompt the user for the first integer
            Console.WriteLine("Please enter an integer that is not 0");
            input = Console.ReadLine();

            //loop through until the value is an integer other that 0
            while ((!(int.TryParse(input, out number1))) || number1==0)
            {

                Console.WriteLine(input + " is not a valid  input");
                Console.WriteLine("please enter a whole number that is not 0 :");
                input = Console.ReadLine();
            }

            // prompt the user for the second integer
            Console.WriteLine("Please enter another integer that is not 0");
            input = Console.ReadLine();

            //loop through until the value is an integer other that 0
            while ((!(int.TryParse(input, out number2))) || number2 == 0)
            {

                Console.WriteLine(input + " is not a valid  input");
                Console.WriteLine("please enter a whole number that is not 0:");
                input = Console.ReadLine();
            }

            //find out the absolut value of the numbers
            if(number1<0)
            {
                absoluteNum1 = number1 * -1;
            }

            else
            {
                absoluteNum1 = number1;
            }

            if (number2 < 0)
            {
                absoluteNum2 = number2 * -1;
            }

            else
            {
                absoluteNum2 = number2;
            }

            //compare the two numbers and assign the value of the smaller number to GCF
            if(absoluteNum1<absoluteNum2)
            {
                GCF = absoluteNum1;
            }
            else
            {
                GCF = absoluteNum2;
            }

            Console.WriteLine("Processing.....");

            //loop through the numbers to find the GCF
            for(int i=GCF; i>1; --i)
            {
                if((number1 % i ==0)&&(number2 % i ==0))
                {
                    GCF = i;
                    GCFfound = true;
                    //if the GCF is found break out of the loop
                    if(GCFfound)
                    {
                        break;
                    }
                } 
                
            }


            //display the message if the GCF is found
            if(GCFfound)
            {
                Console.WriteLine($"The greatest common factor of {number1} and {number1} is {GCF}");
            }

            //and if it is not
            else
            {
                Console.WriteLine($"there is no greatest common factor of {number1} and {number2}");
            }

            Console.ReadLine();

        }
    }
}
