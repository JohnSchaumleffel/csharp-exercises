﻿using System;

namespace AreaRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            AreaOfRectangle rect = new AreaOfRectangle();
            rect.ComputeArea();
        }
            public class AreaOfRectangle
            {
                double length;
                double width;
                double area;
                string input_length;
                string input_width;

                public void ComputeArea()
                {
                    Console.WriteLine("What is the length of the rectangle?");
                    input_length = Console.ReadLine();
                    length = double.Parse(input_length);
                    Console.WriteLine("What is the width of the rectangle?");
                    input_width = Console.ReadLine();
                    width = double.Parse(input_width);

                    area = (length * width);
                    Console.WriteLine("The area of the rectangle is " + area);
                    Console.ReadLine();
                }
            }
        }
    }

