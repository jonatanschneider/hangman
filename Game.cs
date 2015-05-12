using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_v2._0
{
    class HangmanGame
    {
        public string WordToGuess { get; set; }
        
        public string GuessedLetter { get; set; }

        public string[] WildcardsAndGuessedLetters { get; set; }

        public int CountAttempts { get; set; }

        /// <summary>
        /// Fills the Array with Wildcards "_ "
        /// </summary>
        public void FillArrayWithWildcards()
        {
            //Hier ist ein Fehler, wegen fehlender Array Initialisierung
            for (int i = 0; i < WildcardsAndGuessedLetters.Length; i++)
            {
                WildcardsAndGuessedLetters[i] = "_ ";
            }
        } 
        /// <summary>
        /// Writes Correct Letters in the Wildcard-Array
        /// </summary>
        public void WriteCorrectLetterInArray()
        {
            string letter = this.GuessedLetter;
            int position = IsLetterInWordChecker();
            if (position != -1) {
            WildcardsAndGuessedLetters[position] = letter;
            }
        }
        /// <summary>
        /// Checks if the Letter is in the Word
        /// </summary>
        /// <returns>Postion of the Letter in the Word</returns>
        public int IsLetterInWordChecker()
        {
            string word = this.WordToGuess;
            string letter = this.GuessedLetter;
            CountAttempts++;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == letter[0])
                {
                    return i;
                }
            }
            return -1;
        }

        public string WriteWildcardsAndGuessedLetters()
        {
            foreach (string value in this.WildcardsAndGuessedLetters){
                Console.Write(value);
            }
            return "";
        }

        /// <summary>
        /// Draws the Hangman
        /// </summary>
        public void DrawHangman()
        {
            int counter = CountAttempts;
            switch (counter)
            {
                case 1:
                    Console.WriteLine("Strich 1");
                    break;
                case 2:
                    Console.WriteLine("Strich 2");
                    break;
                case 3:
                    Console.WriteLine("Strich 3");
                    break;
                case 4:
                    Console.WriteLine("Du hast leider zu viele Versuche gebraucht! Game over!");
                    break;
                default:
                    Console.WriteLine("Fehler");
                    break;
            }
        }
    }
}