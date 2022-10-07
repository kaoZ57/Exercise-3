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
        //string[] vocabulary = { "sheep", "goat", "computer", "america", "watermelon", "icecream", "jasmine", "pineapple", "orange", "mango" };
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
            //Console.WriteLine(mysteryWord);
        }
        public void GetDisplay()
        {
            guess = new char[mysteryWord.Length];
            for (int p = 0; p < mysteryWord.Length; p++)
            {
                guess[p] = '*';
            }
            Console.WriteLine(guess);
        }
        public void Input(char playerGuess)
        {
            int j;
            for (j = 0; j < mysteryWord.Length; j++)
            {
                if (playerGuess == mysteryWord[j])// Correct
                {
                    guess[j] = playerGuess;

                    if (new string(guess) == mysteryWord)// win
                    {
                        Console.WriteLine(guess);
                        Console.Write("Congratulation,you’re win.");
                        break;
                    }

                    Console.Write(guess);
                    break;
                }
                else if (playerGuess == guess[j])// Duplicate
                {
                    Console.Write(guess);
                    Console.Write("You have already tried this character.");
                    break;
                }
            }

            if (j == mysteryWord.Length)// Incorrect
            {
                Console.Write(guess);
                remaining -= 1;
            }
            if (remaining <= 0)
            {
                Console.Write("Condolences,you’re lose.");
            }
            Console.WriteLine();

            //.WriteLine("\nguess.Length: " + guess.Length);
            //Console.WriteLine("mysteryWord.Length: " + mysteryWord.Length
            //return Enum.GetValues(typeof(check));
        }
        public string GetRemainingTry()
        {
            return "Remaining: " + remaining;
        }
    }
}
