using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class HangmanService
    {
        //string[] vocabulary = { "sheep", "goat", "computer", "america", "icecream", "jasmine", "orange", "mango" };
        string[] vocabulary = { "goat" };
        string mysteryWord;
        char[] guess;
        int remaining = 10;
        enum check { Correct, Incorrect, Duplicate }

        public void Restart()
        {
            Console.WriteLine("Welcome to Hangman game");
            Random randGen = new Random();
            var idx = randGen.Next(0, vocabulary.Length - 1);
            mysteryWord = vocabulary[idx];
            guess = new char[mysteryWord.Length];
            for (int p = 0; p < mysteryWord.Length; p++)
            {
                guess[p] = '*';
            }
            //Console.WriteLine(mysteryWord);
        }
        public void GetDisplay()
        {
            Console.WriteLine(guess);
        }
        public void Input(char playerGuess)
        {
            int j;
            for (j = 0; j < mysteryWord.Length; j++)
            {
                if (playerGuess == guess[j])// Duplicate
                {
                    Console.WriteLine("You have already tried this character.");
                    break;
                }
                else if (playerGuess == mysteryWord[j])// Correct
                {
                    guess[j] = playerGuess;

                    if (new string(guess) == mysteryWord)// Win
                    {
                        GetDisplay();
                        Console.WriteLine("Congratulation,you’re win.");
                        break;
                    }

                    GetDisplay();
                    break;
                }
            }
            if (j == mysteryWord.Length)// Incorrect
            {
                remaining -= 1;
                Console.WriteLine("Sorry, you ’re wrong. Remaining.");
                Console.WriteLine(GetRemainingTry());
            }
            if (remaining <= 0)
            {
                Console.WriteLine("Condolences,you’re lose.");
            }
        }
        public string GetRemainingTry()
        {
            return "Remaining: " + remaining;
        }
    }
}
