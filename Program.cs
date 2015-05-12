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
            /*  
              string wordToGuess = "Beispiel";
              string guessedLetter;

              string[] wordToGuessOutprint = new string[wordToGuess.Length];
            
              Console.WriteLine("Geben Sie ihren ersten Tipp ab");
              guessedLetter = Console.ReadLine();

              //Schreibt einen Platzhalter in ein Array
              for (int j = 0; j < wordToGuess.Length; j++)
              {
                  wordToGuessOutprint[j] = "_ ";
              }

            

              for (int i = 0; i < wordToGuess.Length; i++)
              {
                  if (wordToGuess[i] == guessedLetter[0])
                  {
                      //guessedLetter auf Position [i] ausgeben
                      wordToGuessOutprint[i] = guessedLetter;
                  }
              }
              //Gibt das Array mit den Platzhalern/eratenen Buchstaben aus
              foreach (string value in wordToGuessOutprint)
              {
                  Console.Write(value);
              }
              Console.Read();
             */
        }

        private static HangmanGame CreateNewGame()
        {
            HangmanGame game = new HangmanGame();

            game.WordToGuess = "Beispiel";
            game.CountAttempts = 0;
            while (game.CountAttempts < 4)
            {
                Console.WriteLine("Geben Sie Ihren ersten Tipp ab!");
                game.GuessedLetter = Console.ReadLine();
                game.FillArrayWithWildcards();
                game.IsLetterInWordChecker();
                if (game.IsLetterInWordChecker() > -1)
                {
                    game.DrawHangman();
                }
                game.WriteCorrectLetterInArray();
                game.WriteWildcardsAndGuessedLetters();
            }
            Console.ReadLine();

            return game;
        }

    }
}
