using System;

namespace Day2Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //for loop
            for (int i = 0; i <= 100; i=i+1)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            //while loop
            bool runProgram = true;
            while (runProgram)
            {

                while (true)
                {
                    Console.WriteLine("Do you want to continue looping? (y/n)");
                    string answer = Console.ReadLine();
                    if (answer == "n")
                    {
                        runProgram = false;
                        break;
                    }
                    else if (answer == "y")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid answer.");
                    }
                }
            }

            //sum with for loop
            int sum = 0;

            for (int i = 0; i <= 5; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);


        }
    }
}
