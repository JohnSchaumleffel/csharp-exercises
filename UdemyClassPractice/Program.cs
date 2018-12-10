using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyPractice.Math;
using System;

//Depending on what is being run a brace may need to be added at the end of the program.

namespace UdemyPractice
{
    //For enum Practice
    /*
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    */
    //For Reference and Value Type Practice
    public class Persons
    {
        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var numbers = 1;
            Increment(numbers);
            Console.WriteLine(numbers);
            Console.ReadLine();

            var persons = new Persons() {Age = 20 };
            MakeOld(persons);
            Console.WriteLine(persons.Age);
            Console.ReadLine();
        }

            public static void Increment(int numbers)
            {
                numbers += 10;
            }

            public static void MakeOld(Persons persons)
            {
                persons.Age += 10;
            }

            //Class Practice

            /*
            Person john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
            Console.ReadLine();
            //Class Practice

            //Array Practice


            var numbers = new int[3];
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.ReadLine();

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);
            Console.ReadLine();

            var names = new string[3] { "Jack", "John", "Mary" };

            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.ReadLine();
            //Array Practice
            
            //String Practice

            
            var firstName = "John";
            var lastName = "Schaumleffel";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}.", firstName, lastName);

            var namesArray = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(", ", namesArray);

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(fullName);
            Console.WriteLine(myFullName);
            Console.WriteLine(formattedNames);
            Console.ReadLine();

            var text = @"Hi John
Look into the following paths.
c:\folder1\folder2
c:\folder3\folder4";
            Console.WriteLine(text);
            Console.ReadLine();
            //String Practice
            

            //Enum Practice-Must be defined at the namespace level


            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);
            Console.ReadLine();

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);
            Console.ReadLine();

            Console.WriteLine(method.ToString());
            Console.ReadLine();

            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod);
            Console.ReadLine();
            

            //Reference Types and Value Types

            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));
            Console.ReadLine();

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;

            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));
            Console.ReadLine();
            */


        }
    }

