using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeProjectWeekTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            do
            {
                int vol = 15;
                string[] volunteers = new string[15];
                string[] guards = new string[5];

                Console.WriteLine("Welcome to the Crossing Guard Generator");
                Console.WriteLine("Enter the 15 volunteer's last names");
                
                for (int i = 0; i < volunteers.Length; i++)
                {
                    string input = Console.ReadLine().ToLower();
                    if (volunteers.Contains(input) == true)
                    {
                        Console.WriteLine("No Duplicates. Enter another name");
                        i--;
                        vol++;
                    }
                    volunteers[i] = input;
                    vol--;
                    Console.WriteLine("You have " + vol + " names left to enter");
                }

                Console.WriteLine("Here's your volunteer list:");
                foreach (string volunteer in volunteers)
                {
                    Console.WriteLine(volunteer);
                }

                //Random guard generator
                Random rand = new Random();
                for (int i = 0; i < guards.Length; i++)
                {

                    int index = rand.Next(volunteers.Length);
                    string inputTwo = volunteers[index];

                    if (guards.Contains(inputTwo) == false)
                    {
                        guards[i] = inputTwo;
                    }
                    else
                    {
                        i--;
                    }

                }

                Console.WriteLine("Thank you very much for volunteering. Each of you will get a chance to participate in the Crossing Guard program. The following five volunteers have been chosen for next weeks Crossing Guard positions:");
                Array.Sort<string>(guards);
                foreach (string guard in guards)
                {
                    Console.WriteLine(guard);
                }

                Console.WriteLine("Do you wish to re-run the program?");
                Console.WriteLine("Type exit to quit or enter to continue");
                string response = Console.ReadLine().ToLower();
                if(response == "exit")
                {
                    exit = true;
                }

            } while (exit == false);
        
        }
    }
}
