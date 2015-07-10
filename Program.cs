using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_v2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            HangmanGame game1 = Program.CreateNewGame();

        }
        private static HangmanGame CreateNewGame()
        {
            HangmanGame game = new HangmanGame();

            Console.WriteLine("Geben Sie das zu suchende Wort ein");
            game.WordToGuess = Console.ReadLine().ToUpper();
            Console.WriteLine("Geben Sie einen Buchstaben ein");
            game.GuessedLetter = Console.ReadLine().ToUpper();
            game.IncreaseAttemptsCounter();
            game.IsLetterInWordChecker();
        
            Console.ReadLine();
            return game;

        }

    }
}
