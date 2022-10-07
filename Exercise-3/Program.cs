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
            UP:
                try
                {
                    Console.Write("\nplease enter character: ");
                    playerGuess = char.Parse(Console.ReadLine());

                    if (playerGuess.ToString() == "")
                    {
                        goto Restart;
                    }
                }
                catch (Exception)
                {
                    goto UP;
                }

                hangman.Input(playerGuess);
                Console.WriteLine(hangman.GetRemainingTry());
            }
        }
    }
}
