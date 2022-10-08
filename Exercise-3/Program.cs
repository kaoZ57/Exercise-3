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
        Restart:
            HangmanService hangman = new HangmanService();
            hangman.Restart();

            hangman.GetDisplay();

            while (true)
            {
                char playerGuess;
                try
                {
                    Console.Write("\nplease enter character: ");
                    playerGuess = char.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.Clear();
                    goto Restart;
                }

                hangman.Input(playerGuess);
            }
        }
    }
}
