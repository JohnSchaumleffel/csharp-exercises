using System;

namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string textBlock;

            textBlock = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                "Nunc accumsan sem ut ligula scelerisque sollicitudin. " +
                "Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. " +
                "Donec sit amet suscipit metus, non lobortis massa. " +
                "Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. " +
                "Donec nec velit non ligula efficitur luctus.";

            foreach (char letter in textBlock)
            {
                Console.WriteLine(letter);
                Console.ReadLine();
            }


        }
    }
}