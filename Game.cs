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

        private char[] WrongLetters { get; set; }

        private char[] OutputArray { get; set; }


        private char[] WordToArray()
        {
            char[] wordInArray = this.WordToGuess.ToCharArray();
            return wordInArray;
        }
        
        public bool IsLetterInWordChecker()
        {
            char[] word = this.WordToArray();
            char letter = Convert.ToChar(this.GuessedLetter);

            for (int i = 0; i < word.Length; i++)
            {
                if (letter == word[i])
                {
                    this.CorrectLetterToArray(i);
                    return true;
                }
            }
            WrongLetterToArray(letter);
            IncreaseWrongAttemptsCounter();
            return false;
        }

        private void IncreaseWrongAttemptsCounter(){
            this.countWrongAttempts++;
            HangmanDrawer();
        }

        public void IncreaseAttemptsCounter()
        {
            this.countAllAttempts++;
        }

        private void HangmanDrawer()
        {
            //TODO: Implement Hangman-"Drawing"
            switch (this.countWrongAttempts)
            {
                case 1:
                    Console.WriteLine("Stufe 1");
                    break;
                case 2:
                    Console.WriteLine("Stufe 2");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }

            UserInput();
        }

        public void WrongLetterToArray(char letter)
        {
            this.WrongLetters = new char[WordToGuess.Length];
            int attempt = this.countAllAttempts;
            this.WrongLetters[attempt] = letter;
        }

        public void WildcardsToArray()
        {
            for (int i = 0; i < this.WordToGuess.Length; i++)
            {
                this.OutputArray[i] = '_';
            }
            this.WriteOutputArray();
        }

        public void WriteOutputArray()
        {
            foreach (char item in this.OutputArray)
            {
                Console.WriteLine(item);
            }
        }

        public void CorrectLetterToArray(int positionInArray)
        {
            this.OutputArray = new char[WordToGuess.Length];
            this.OutputArray[positionInArray] = Convert.ToChar(this.GuessedLetter);
            this.WriteOutputArray();
            this.UserInput();
        }

        public void UserInput()
        {
            Console.WriteLine("Geben Sie einen Buchstaben ein");
            this.GuessedLetter = Console.ReadLine().ToUpper();
            this.IncreaseAttemptsCounter();
            this.IsLetterInWordChecker();
        }
    }
}