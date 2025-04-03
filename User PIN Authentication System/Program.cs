using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        const int pinNum = 1234; 
        int attempts = 0;
        int userInput;
        do
        {
            Console.Write("Please enter a correct 4 digit Pin: ");
            userInput = Convert.ToInt32(Console.ReadLine());
            attempts++;

            if (userInput == pinNum)
            {
               
                Console.WriteLine("Access Granted");
                return;
            }
            else
            {
                Console.WriteLine( (3 - attempts) + " Attempts left. Incorrect Pin ");
            }

        }
        while (attempts < 3);

        Console.WriteLine("Access Denied");
        
          
    }
}