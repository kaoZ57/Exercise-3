using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class HangmanService
    {
        //string[] vocabulary = { "sheep", "goat", "computer", "america", "watermelon", "icecream", "jasmine", "pineapple", "orange", "mango" };
        string[] vocabulary = { "goat" };
        string mysteryWord;
        char[] guess;
        int remaining;
        enum check { Correct, Incorrect, Duplicate }

        public void Restart()
        {
            Console.WriteLine("Welcome to Hangman game");
            Random randGen = new Random();
            var idx = randGen.Next(0, vocabulary.Length - 1);
            mysteryWord = vocabulary[idx];
            Console.WriteLine(mysteryWord);
            Console.WriteLine();
        }
        public void GetDisplay()
        {
            guess = new char[mysteryWord.Length];
            for (int p = 0; p < mysteryWord.Length; p++)
            {
                guess[p] = '*';
            }
        }
        public void Input(char playerGuess)
        {
            for (int j = 0; j < mysteryWord.Length; j++)
            {
                if (playerGuess == mysteryWord[j])
                {
                    guess[j] = playerGuess;
                }
                Console.Write(guess[j]);
            }
            Console.WriteLine("\nguess.Length: " + guess.Length);
            Console.WriteLine("mysteryWord.Length: " + mysteryWord.Length);
            Console.WriteLine();
            //return Enum.GetValues(typeof(check));
        }
        public int GetRemainingTry()
        {
            return remaining;
        }
    }
}
