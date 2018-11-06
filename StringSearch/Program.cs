using System;

namespace StringSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            string source_material;
            string search_phrase;
            string lc_source_material;
            string lc_search_phrase;

            source_material = ("Alice was beginning to get very tired of sitting " +
                "by her sister on the bank, and of having nothing to do: once or twice " +
                "she had peeped into the book her sister was reading, but it had no " +
                "pictures or conversations in it, 'and what is the use of a book,' " +
                "thought Alice 'without pictures or conversation?'");
            lc_source_material = source_material.ToLower();

            Console.WriteLine("What phrase would you like to search for?");
            search_phrase = Console.ReadLine();
            lc_search_phrase = search_phrase.ToLower();

            Console.WriteLine(lc_source_material.Contains(lc_search_phrase));
            Console.ReadLine();


            //functions properly
        }
    }
}
