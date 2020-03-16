using System;
using System.Collections.Generic;
using System.Text;

namespace NumberGame
{
    class Game
    {
        int attempts = 0;
        int maxAttempts = 3;
        int streak = 0;
        RandomNumGen rng = new RandomNumGen();
        int guessingNum;
        public Game()
        {
            guessingNum = rng.RandomNumber(0, 10);
        }

        public void GameScreen()
        {
            while (attempts < maxAttempts)
            {
                string test = Console.ReadLine();
                Console.Clear();

                attempts++;
                try
                {
                    Convert.ToInt32(test);
                }
                catch
                {
                    Console.WriteLine("fuck you. game over");
                    return;
                }

                if (Convert.ToInt32(test) == guessingNum)
                {
                    Console.WriteLine("good job retard");
                }
                else if (Convert.ToInt32(test) < guessingNum)
                {
                    Console.WriteLine("too low dumbass");
                }
                else if (Convert.ToInt32(test) > guessingNum)
                {
                    Console.WriteLine("that's too fucking high. are you dense?");
                }
            }
        }

        public void IntroScreen()
        {
            Console.WriteLine("Enter a number between 0 and 10");
        }

        public void GameOverScreen()
        {
            Console.WriteLine("Game over");
        }
    }
}
