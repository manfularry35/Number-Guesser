using System;

//NAmespace
namespace Number_Guesser
{
    //Main Classes
    class Program
    {
        static int exitCode = 0;
        static string author = "Larry";
        static string version = "v1.0";
        static Boolean status = true;

        static int guess, random_num, max;
        
        static void print()
        {
            Console.WriteLine("Welcome to " + author +  "'s Number Guessing Game!  " + version);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Type 'start' to begin, 'quit' to exit");
        }
        static Boolean checkWord(string word)
        {
            if (word.Equals("start"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /*
        static void checkNum(int num)
        {
            if (num < 10000)
            {
                 throw new Exception
            }

        }
        */
        //Entry point method
        static void Main(string[] args)
        {
            int tries = 10;
            Boolean numCheck = false;
            print();
            string input = Console.ReadLine();
            Console.WriteLine(" ");
            if (checkWord(input))
            {
               
               

                try
                {
                    do
                    {
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("Enter a number (more than 10000): ");
                        max = int.Parse(Console.ReadLine());
                    } while (max < 10000);
                    
                    
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Enter a number only please... ");
                }

                

                Console.WriteLine("----------------------------------------");
                Console.WriteLine("A number will now be generated for you to guess. ");
                Random rand = new Random();
                random_num = rand.Next(max);
                Console.WriteLine("Random number has been generated.");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Enter your guess!");
                Console.WriteLine("You have "+ tries + " tries to make your guess.");

                while (status != false && tries != 0  )
                {
                    guess = Convert.ToInt32(Console.ReadLine());
                    if (guess > random_num)
                    {
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("Try a smaller number!");
                        tries--;
                        Console.WriteLine("You have " + tries.ToString() + " tries left" );
                    }
                    else if (guess < random_num)
                    {
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("Try a bigger number!");
                        tries--;
                        Console.WriteLine("You have " + tries.ToString() + " tries left");
                    }
                    else
                    {
                        Console.WriteLine("Your guess was correct!!");
                        status = false;
                    }
                }
            }
            else
            {
                Environment.Exit(exitCode);
            }
           

            Console.WriteLine("To play again, rerun the program....");
            Console.WriteLine("Press the 'Enter' Key to close the program.");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
            }


        }
    }
}
