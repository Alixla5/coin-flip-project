using System;

namespace CoinFlipChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to da COIN FLIP CHALLENGE!");
            Console.Write("What's you're name? ");
            string name = Console.ReadLine();

            Console.WriteLine("Hello wassup " + name + "!");

            Console.Write("Do you wanna try COIN FLIP CHALLENGE? (Yes/No) ");
            string response = Console.ReadLine();

            if (response.ToLower() == "yes")
            {
                int score = 0;

                Console.WriteLine("Heads or Tails?");

                for (int i = 0; i < 5; i++)
                {
                    Random random = new Random();
                    int randomNumber = random.Next(2);

                    Console.Write("What do you think? ");
                    string guess = Console.ReadLine();

                    if ((guess.ToLower() == "heads" && randomNumber == 0) || (guess.ToLower() == "tails" && randomNumber == 1))
                    {
                        Console.WriteLine("You got it right, champ!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, wrong guess!");
                    }
                }

                Console.WriteLine("Great job, " + name + ". Your score be " + score + "!");
            }
            else
            {
                Console.WriteLine(" You're too scared, " + name + "!");
            }

            Console.ReadLine();
        }
    }
}
