using System;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //escaping characters with back-slash
            //string myString = "My \"so-called\" life";

            //forcing text to a new line using \n
            //string myString = "What if I need a\nnew line?";

            //using the back-slash in a string as a character
            //string myString = "Go to your c:\\ drive"; //you can escape it with another back-slash
            //string myString = @"Go to you c:\ drive"; //putting the @ symbol in front of the string tells the complier to treat \ like a normal character

            //using formatting to substitute in values
            //string myString = String.Format("{0} = {1}", "First", "Second");

            //representing money and changing currency changing the C will effect how it represented
            //string myString = string.Format("{0:C}", 123.45);

            //long numbers adds appropriate formatting
            //string myString = string.Format("{0:N}", 1234567890);

            //represent a number as a percent
            //string myString = string.Format("{0:P}", .123);

            //create a custom format
            //string myString = string.Format("Phone Number: {0:(###) ###-####}", 1234567890);

            //string myString = " That summer we took threes across the board  ";

            //selecting parts of a string
            //myString = myString.Substring(6, 14);

            //make everything upper case
            //myString = myString.ToUpper();

            //replace character
            //myString = myString.Replace(" ", "--");

            //remove characters or whole pieces of a string
            //myString = myString.Remove(6, 14);

            //remove space at beginnning and end of a string
            //myString = myString.Trim();

            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
