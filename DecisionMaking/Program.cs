using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey there, please enter your name: ");
            string userName = Console.ReadLine();

            Console.WriteLine("Thanks for that " + userName + ". Please enter an integer (whole number) between 1 and 100.");
            int userNum = int.Parse(Console.ReadLine());

            if ((userNum % 2 == 0) && (userNum >= 1) && (userNum < 25))
            {
                Console.WriteLine("Even and less than 25");
            }
            else if ((userNum % 2 == 0) && (userNum >= 26) && (userNum <= 60))
            {
                Console.WriteLine("Even");
            }
            else if ((userNum % 2 == 0) && (userNum >= 60) && (userNum <= 100))
            {
                Console.WriteLine(userNum + " Even");
            }
            else if ((userNum % 2 != 0) && (userNum <= 59))
            {
                Console.WriteLine("Odd");
            }
            else if ((userNum % 2 != 0) && (userNum >= 61) && (userNum <= 100))
            {
                Console.WriteLine(userNum + " Odd");
            }
            else
            {
                Console.WriteLine(userName + ", I said between 1-100."); 
            }

            Console.WriteLine("Thanks for that " + userName + ", have a good day. Press any key to exit");
            Console.ReadKey();


        }
    }
}
