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

        private int countAllAttempts;

        public int CountAllAttempts
        {
            get { return countAllAttempts; }
        }

        private int countWrongAttempts;

        public int CountWrongAttempts
        {
            get { return countWrongAttempts; }
        }

        public char[] OutputLetter { get; set; }

        private char[] WrongLetters { get; set; }

        /// <summary>
        /// Used for choice of the right case in HangmanDrawer
        /// </summary>
        private void IncreaseWrongAttemptsCounter()
        {
            this.countWrongAttempts++;
            HangmanDrawer();
        }

        /// <summary>
        /// Counts every attempt of the user
        /// </summary>
        public void IncreaseAttemptsCounter()
        {
            this.countAllAttempts++;
        }

        /// <summary>
        /// Returns the to guessing word in char Array
        /// </summary>
        /// <returns>Guessed Word in char Array</returns>
        private char[] WordToArray()
        {
            char[] wordInArray = this.WordToGuess.ToCharArray();
            return wordInArray;
        }

        private void LetterIsNotInWord(char letter)
        {
            WrongLetterToArray(letter);
            IncreaseWrongAttemptsCounter();
        }

        public void IsLetterInWordChecker()
        {
            char[] word = this.WordToArray();
            char letter = Convert.ToChar(this.GuessedLetter);
            bool letterInWord = false;

            for (int i = 0; i < word.Length; i++)
            {
                if (letter == word[i])
                {
                    this.OutputLetter[i] = Convert.ToChar(this.GuessedLetter);
                    letterInWord = true;
                }
            }
            this.WriteOutput();

            if (letterInWord == false)
            {
                this.LetterIsNotInWord(letter);
            }

            this.UserInput();
        }

        private void HangmanDrawer()
        {
            switch (this.countWrongAttempts)
            {
                case 1:
                    Console.WriteLine("Stufe 1");
                    break;
                case 2:
                    Console.WriteLine("Stufe 2");
                    break;
                case 3:
                    Console.WriteLine("Stufe 3");
                    break;
                case 4:
                    Console.WriteLine("Stufe 4");
                    break;
                case 5:
                    Console.WriteLine("Game Over!");
                    Console.WriteLine("Zum Beenden beliebige Taste drücken");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }

        /// <summary>
        /// Writes a wrong letter in an Array
        /// </summary>
        /// <param name="letter">The guessed letter</param>
        public void WrongLetterToArray(char letter)
        {
            this.WrongLetters = new char[6];
            int attempt = this.countAllAttempts;
            this.WrongLetters[attempt] = letter;
        }

       public void WriteOutput()
       {
           for (int i = 0; i < this.WordToGuess.Length; i++)
           {
               if (this.OutputLetter[i] != '\0')
               {
                   Console.Write(this.OutputLetter[i]);
                   Console.Write(" ");
               }
               else if (this.OutputLetter[i] == '\0')
               {
                   Console.Write('_');
                   Console.Write(" ");
               }
           }
           Console.WriteLine();
       }

        /// <summary>
        /// The input the user has to make before working the code off
        /// </summary>
        public void UserInput()
        {
            Console.WriteLine("Geben Sie einen Buchstaben ein");
            this.GuessedLetter = Console.ReadLine().ToUpper();
            Console.WriteLine();
            this.IncreaseAttemptsCounter();
            this.IsLetterInWordChecker();

        }
    }
}