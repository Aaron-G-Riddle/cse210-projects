using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Aaron Riddle", "Statistics");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathassignment = new MathAssignment("Aaron Riddle", "Statistics", "7.3", "8-19");
        Console.WriteLine(mathassignment.GetHomeworkList());

        Assignment assignment2 = new Assignment("Mary Waters", "European History");
        Console.WriteLine(assignment2.GetSummary());

        WritingAssignment writingassignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingassignment.GetWritingInfo());
    }
}