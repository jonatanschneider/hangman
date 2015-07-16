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

        public char[] WrongLetters { get; set; }

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

            this.UserInputWithWrongLetters();
        }

        private void HangmanDrawer()
        {
            switch (this.countWrongAttempts)
            {
                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine(" ___________");
                    Console.WriteLine("|           |");
                    break;
                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine(" ___________");
                    Console.WriteLine("|           |");
                    break;
                case 3:
                    Console.WriteLine("");
                    Console.WriteLine("      | /         ");
                    Console.WriteLine("      |/");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine(" ___________");
                    Console.WriteLine("|           |");
                    break;
                case 4:
                      Console.WriteLine("      ______________");
                    Console.WriteLine("      | /         ");
                    Console.WriteLine("      |/");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine(" ___________");
                    Console.WriteLine("|           |");
                    break;
                case 5:
                      Console.WriteLine("      ______________");
                    Console.WriteLine("      | /         |");
                    Console.WriteLine("      |/");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine(" ___________");
                    Console.WriteLine("|           |");
                    break;
                case 6:
                      Console.WriteLine("      ______________");
                    Console.WriteLine("      | /         |");
                    Console.WriteLine("      |/         ( )");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine(" ___________");
                    Console.WriteLine("|           |");
                    break;
                case 7:
                      Console.WriteLine("      ______________");
                    Console.WriteLine("      | /         |");
                    Console.WriteLine("      |/         ( )");
                    Console.WriteLine("      |           |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine(" ___________");
                    Console.WriteLine("|           |");
                    break;
                case 8:
                      Console.WriteLine("      ______________");
                    Console.WriteLine("      | /         |");
                    Console.WriteLine("      |/         ( )");
                    Console.WriteLine("      |         \\ |");
                    Console.WriteLine("      |          \\|");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine(" ___________");
                    Console.WriteLine("|           |");
                    break;
                case 9:
                    Console.WriteLine("        ____________");
                    Console.WriteLine("      | /         |");
                    Console.WriteLine("      |/         ( )");
                    Console.WriteLine("      |         \\ | /");
                    Console.WriteLine("      |          \\|/");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine(" ___________");
                    Console.WriteLine("|           |");
                    break;
                case 10:
                    Console.WriteLine("        ____________");
                    Console.WriteLine("      | /         |");
                    Console.WriteLine("      |/         ( )");
                    Console.WriteLine("      |         \\ | /");
                    Console.WriteLine("      |          \\|/");
                    Console.WriteLine("      |           |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine(" ___________");
                    Console.WriteLine("|           |");
                    break;
                case 11:
                    Console.WriteLine("        ____________");
                    Console.WriteLine("      | /         |");
                    Console.WriteLine("      |/         ( )");
                    Console.WriteLine("      |         \\ | /");
                    Console.WriteLine("      |          \\|/");
                    Console.WriteLine("      |           |");
                    Console.WriteLine("      |          /");
                    Console.WriteLine("      |         /");
                    Console.WriteLine(" ___________");
                    Console.WriteLine("|           |");
                    break;
                case 12:
                    Console.WriteLine("        ____________");
                    Console.WriteLine("      | /         |");
                    Console.WriteLine("      |/         ( )");
                    Console.WriteLine("      |         \\ | /");
                    Console.WriteLine("      |          \\|/");
                    Console.WriteLine("      |           |");
                    Console.WriteLine("      |          / \\");
                    Console.WriteLine("      |         /   \\");
                    Console.WriteLine(" ___________");
                    Console.WriteLine("|           |");
                    Console.WriteLine("Game Over!");
                    Console.WriteLine("Beliebige Taste zum Beenden drücken.");
                    Console.ReadLine();
                    Environment.Exit(1);
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
            int attempt = this.CountWrongAttempts;
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

       public bool IsWordCompletlyGuessed()
       {
           string guess = new string(this.OutputLetter);

           if (guess.Equals(this.WordToGuess))
           {
               return true;
           }

           return false;
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

        public void UserInputWithWrongLetters()
        {
            if (IsWordCompletlyGuessed())
            {
                Console.WriteLine("Glückwunsch Sie haben das Wort eraten!");
                Console.WriteLine("Zum Beenden beliebige Taste drücken.");
                Console.ReadLine();
                Environment.Exit(1);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Bisher Falsch geratene Buchstaben = ");
                Console.WriteLine(this.WrongLetters);
                Console.WriteLine("Geben Sie einen Buchstaben ein");
                this.GuessedLetter = Console.ReadLine().ToUpper();
                Console.WriteLine();
                this.IncreaseAttemptsCounter();
                this.IsLetterInWordChecker();
            }
        }
    }
}