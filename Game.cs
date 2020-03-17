﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberGame
{
    class Game
    {
        int attemptsLeft;
        int maxAttempts = 3;
        int streak = 0;
        RandomNumGen rng = new RandomNumGen();
        int guessingNum;
        bool gameover = false;
        string name = "asshole";
        List<HighScore> highscores = new List<HighScore>();

        public Game()
        {
            attemptsLeft = maxAttempts;
            guessingNum = rng.RandomNumber(0, 10);

            // makes highscores ordered properly
            List<HighScore> ordered = highscores.OrderByDescending(HighScore => HighScore.Score).ToList();
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
            while (attemptsLeft > 0)
            {
                string test = Console.ReadLine();
                Console.Clear();

                if (CheckIfNumber(test) == true)
                {
                    attemptsLeft--;

                    if (Convert.ToInt32(test) == guessingNum)
                    {
                        guessingNum = rng.RandomNumber(0, 10);
                        maxAttempts += attemptsLeft;
                        attemptsLeft = maxAttempts; // how does this make sense? after a few attempts it becomes impossible to lose
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
                    if (attemptsLeft == 0)
                    {
                        gameover = true;
                    }
                }
                else
                {
                    Console.WriteLine("yeah real funny asshole");
                    attemptsLeft = 0;
                }

            }
        }

        public void UI(string feedback)
        {
            Console.WriteLine("streak: {0}",streak);
            Console.WriteLine("Attempts: {0} of {1}", attemptsLeft, maxAttempts);
            Console.WriteLine("Enter a number between 0 and 10");
            Console.WriteLine(feedback);


        }



        public void GameOverScreen()
        {
            Console.WriteLine("Game over");
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
        }


        public void AddScore()
        {
            HighScore score = new HighScore(name, streak);
            highscores.Add(score);
        }
    }
}
