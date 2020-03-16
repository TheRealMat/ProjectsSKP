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
        bool gameover = false;

        public Game()
        {
            guessingNum = rng.RandomNumber(0, 10);
        }
        public bool CheckIfNumber(string entry)
        {
            try
            {
                Convert.ToInt32(entry);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public void GameScreen()
        {
            UI("asdasd");
            while (attempts < maxAttempts)
            {
                string test = Console.ReadLine();
                Console.Clear();

                if (CheckIfNumber(test) == true)
                {
                    attempts++;

                    if (Convert.ToInt32(test) == guessingNum)
                    {

                        guessingNum = rng.RandomNumber(0, 10);
                        attempts = 0;
                        streak++;
                        UI("good job retard");
                    }
                    else if (Convert.ToInt32(test) < guessingNum)
                    {
                        UI("too low dumbass");
                    }
                    else if (Convert.ToInt32(test) > guessingNum)
                    {
                        UI("that's too fucking high. are you dense?");
                    }
                    if (attempts >= maxAttempts)
                    {
                        gameover = true;
                    }
                }
                else
                {
                    Console.WriteLine("yeah real funny asshole");
                    attempts = maxAttempts;
                }


            }
        }

        public void UI(string feedback)
        {
            Console.WriteLine("streak: {0}",streak);
            Console.WriteLine("Attempts: {0} of {1}", attempts, maxAttempts);
            Console.WriteLine("Enter a number between 0 and 10");
            Console.WriteLine(feedback);


        }



        public void GameOverScreen()
        {
            Console.WriteLine("Game over");
        }
    }
}
