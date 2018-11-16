using System;
using System.Collections.Generic;

namespace School
{
    class Program
    {
        public static void Main(string[] args)
        {

        }
    }

    public class Student
    {
        string name;
        int studentId;
        int numberOfCredits;
        double gpa;
    }

    public class Course
    {
        Dictionary<string, double> RosterDict = new Dictionary<string, double>();
        string courseName;
        double creditHours;
        
        
    }
}
