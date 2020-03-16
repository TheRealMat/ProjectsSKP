using System;

namespace NumberGame
{
    public class Program
    {
        int guessingNum { get; set; }
        public static void Main(string[] args)
        {

            Game game = new Game();

            game.GameScreen();
            game.GameOverScreen();

        }
    }
}
