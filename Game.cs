using System;

namespace Hangman_v2._0
{
    class HangmanGame
    {
        /// <summary>
        /// Speichert das zu eratene Wort
        /// </summary>
        public string WordToGuess { get; set; }

        /// <summary>
        /// Speichert den aktuell geratenen Buchstaben
        /// </summary>
        public string GuessedLetter { get; set; }

        /// <summary>
        /// Zählt alle Versuche
        /// </summary>
        private int countAllAttempts;

        /// <summary>
        /// Zählt nur die Fehlversuche
        /// </summary>
        private int countWrongAttempts;

        /// <summary>
        /// Speichert die Buchstaben die ausgegeben werden
        /// </summary>
        public char[] OutputLetter { get; set; }

        /// <summary>
        /// Speichert die falsch geratenen Buchstaben
        /// </summary>
        public char[] WrongLetters { get; set; }

        /// <summary>
        /// Erhöht WrongAttempts und ruft den Drawer auf
        /// </summary>
        private void IncreaseWrongAttemptsCounter()
        {
            this.countWrongAttempts++;
            HangmanDrawer();
        }

        /// <summary>
        /// Erhöht den Zähler für alle Versuche
        /// </summary>
        public void IncreaseAttemptsCounter()
        {
            this.countAllAttempts++;
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

        /// <summary>
        /// Schreibt das zu eratene Word in ein Char Array
        /// </summary>
        /// <returns>Guessed Word in char Array</returns>
        private char[] WordToArray()
        {
            char[] wordInArray = this.WordToGuess.ToCharArray();
            return wordInArray;
        }

        /// <summary>
        /// Ruft die Methoden auf die bei einem falschen Versuch benötigt werden
        /// </summary>
        /// <param name="letter"></param>
        private void LetterIsNotInWord(char letter)
        {
            WrongLetterToArray(letter);
            IncreaseWrongAttemptsCounter();
        }

        /// <summary>
        /// Zeichnet den Hangman
        /// </summary>
        private void HangmanDrawer()
        {
            DrawSeperationLine();
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
        /// Schreibt einen falschen Buchstaben in ein Array
        /// </summary>
        /// <param name="letter">The wrong guessed letter</param>
        public void WrongLetterToArray(char letter)
        {
            int attempt = this.countWrongAttempts;
            this.WrongLetters[attempt] = letter;
        }

        /// <summary>
        /// Gibt die eratenen Buchstaben und Platzhalter aus
        /// </summary>
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
        /// Die Eingaben die für das Ausführen benötigt werden
        /// </summary>
        public void UserInput()
        {
            DrawSeperationLine();
            Console.WriteLine("Geben Sie einen Buchstaben ein");
            this.GuessedLetter = Console.ReadLine().ToUpper();
            Console.WriteLine();
            bool userInput = IsUserInputCorrectlyEntered();
            if (userInput == false)
            {
                Console.WriteLine("Bitte immer nur einen Buchstaben eingeben!");
                Console.WriteLine("Bitte keine bereits geratenen Buchstaben eingeben!");
                UserInputWithWrongLetters();
            }
            Console.Clear();
            this.IncreaseAttemptsCounter();
            this.IsLetterInWordChecker();
        }

        /// <summary>
        /// Die Eingaben die für das Ausführen benötigt werden + das Ausgeben der falschen Buchstaben
        /// </summary>
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
                DrawSeperationLine();
                Console.Write("Bisher Falsch geratene Buchstaben = ");
                Console.WriteLine(this.WrongLetters);
                DrawSeperationLine();
                Console.WriteLine("Geben Sie einen Buchstaben ein");
                this.GuessedLetter = Console.ReadLine().ToUpper();
                Console.Clear();
                DrawSeperationLine();
                Console.WriteLine();
                bool userInput = IsUserInputCorrectlyEntered();
                if (userInput == false)
                {
                    Console.WriteLine("Bitte immer nur einen Buchstaben eingeben!");
                    Console.WriteLine("Bitte keine bereits geratenen Buchstaben eingeben!");
                    UserInputWithWrongLetters();
                }
                this.IncreaseAttemptsCounter();
                this.IsLetterInWordChecker();
            }
        }

        public void DrawSeperationLine()
        {
            Console.Write(string.Empty.PadLeft(Console.WindowWidth - Console.CursorLeft, '-'));
        }

        public bool IsUserInputCorrectlyEntered()
        {
            if (this.GuessedLetter.Length == 1)
            {
                for (int i = 0; i < WrongLetters.Length; i++)
                {
                    if (WrongLetters[i] == GuessedLetter[0])
                    {
                        return false;
                    }
                }
                for (int j = 0; j < OutputLetter.Length; j++)
                {
                    if (OutputLetter[j] == GuessedLetter[0])
                    {
                        return false;
                    }
                }

                return true;
            }
            return false;
        }
    }
}