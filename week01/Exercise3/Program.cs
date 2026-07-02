using System;

class Program
{
    static void Main(string[] args)
    {
        // pick a random number from 1 to 100 for the magic number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        // start with a guess that can never be the magic number
        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}
