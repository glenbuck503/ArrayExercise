using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;

namespace ArrayExercise
{
    class Program
    {
        static void Main()
        {
            //NUMBER 1

            string[] stringArray = { "red", "yellow", "blue", "green", "pink" };
            Console.WriteLine("Please choose an index number between 0-4. Make sure to put the number in brackets. Example: [1]");
            string yourChoice = Console.ReadLine();
            int yourInput1 = Convert.ToInt32(yourChoice);
            Console.WriteLine(stringArray[yourInput1]);
            

            //NUMBER 2
            int[] numberArray = { 10, 20, 30, 40, 50 };
            Console.WriteLine("PLease enter a number between 0-4");
            string yourInput = Console.ReadLine();
            int yourInput2 = Convert.ToInt32(yourInput);
            Console.WriteLine(numberArray[yourInput2]);

           
            //NUMBER 4 
            List<string> intList = new List<string>();
            intList.Add("Glen");
            intList.Add("Buck");
            intList.Add("Portland");
            intList.Add("Oregon");
            Console.WriteLine("Please enter a number between 0-3");
            string listInput = Console.ReadLine();
            int yourList = Convert.ToInt32(listInput);
            Console.WriteLine(intList[yourList]);
            


            //Number 3   I AM HAVING ISSUS WITH THIS STEP
            int[] numberArray2 = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("Please enter a number between 0-6");
            string wrongNum = Console.ReadLine();
            int wrongNum1 = Convert.ToInt32(wrongNum);

            if (wrongNum1 > 6)

            {
                Console.WriteLine("You have chosen a number greater than 6");
                Console.ReadLine();
            }
                Console.WriteLine(numberArray2[wrongNum1]);
            
            Console.ReadLine();















        }
    }
}
