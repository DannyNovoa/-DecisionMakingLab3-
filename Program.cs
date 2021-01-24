using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;

            while (isRunning == true)
            {
                Console.WriteLine("Enter an integer between 1 and 100: \n");
                int userinput = int.Parse(Console.ReadLine());

                if (userinput >= 1 && userinput <= 100)
                {
                    if (userinput % 2 != 0)
                    {
                        Console.WriteLine("Odd \n");
                    }

                    else if (userinput >= 2 && userinput <= 25 && userinput % 2 == 0)
                    {
                        Console.WriteLine("Even and Less than 25 \n");
                    }

                    else if (userinput >= 26 && userinput <= 60 && userinput % 2 == 0)
                    {
                        Console.WriteLine("Even \n");
                    }

                    else if (userinput > 60 && userinput % 2 == 0)
                    {
                        Console.WriteLine("Even \n");
                    }

                    else if (userinput > 60 && userinput % 2 == 0)
                    {
                        Console.WriteLine("Odd \n");
                    }
                }
                else
                {
                    Console.WriteLine("Lo siento tu input es incorrecto \n");
                }

                Console.WriteLine("Would you like to try another number. Enter (Y/N)? \n");
                string loopbreak = Console.ReadLine();

                if (loopbreak == "Y" || loopbreak == "y")
                {
                    Console.WriteLine(" \n");
                }
                else
                {
                    Console.WriteLine("Adios Muchacho! ");
                    isRunning = false;
                }
                
            }
            Console.ReadKey();
        }
    }
}