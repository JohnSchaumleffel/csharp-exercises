using System;
using System.Collections.Generic;
using System.Linq;

namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            CountingCharacters tabulate = new CountingCharacters();
            tabulate.TabulateCharacters();
        }
            public class CountingCharacters
        {
            //create variables
            string textBlock = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                "Nunc accumsan sem ut ligula scelerisque sollicitudin. " +
                "Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. " +
                "Donec sit amet suscipit metus, non lobortis massa. " +
                "Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. " +
                "Donec nec velit non ligula efficitur luctus.";

            string alphabet = "abcdefghijklmnopqrstuvwxyz, .ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            Dictionary<char, int> LetterCount = new Dictionary<char, int>();

            public void TabulateCharacters()
            {
                foreach (char c in textBlock)
                {
                    if (alphabet.Contains(c))
                    {
                        if (LetterCount.ContainsKey(c))
                        {
                            LetterCount[c] += 1;
                        }
                        else
                        {
                            LetterCount.Add(c, 1);
                        }
                    }
                }
                foreach (KeyValuePair<char, int> c in LetterCount)
                {
                    Console.WriteLine(String.Format("{0}: {1}", c.Key, c.Value));
                }
                Console.ReadKey();
            }
        }

        }
    }
