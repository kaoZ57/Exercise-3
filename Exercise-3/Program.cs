using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HangmanService hangman = new HangmanService();
            hangman.Restart();

            hangman.GetDisplay();

            //Console.Write("\nplease enter character: ");

            //char playerGuess = char.Parse(Console.ReadLine());

            hangman.Input(char.Parse("o"));
            hangman.Input(char.Parse("t"));
            hangman.Input(char.Parse("g"));
            hangman.Input(char.Parse("a"));
            //hangman.GetRemainingTry();


            /*while (true)
            {
                hangman.GetDisplay();
                hangman.Input();
            }*/
        }
    }
}
