using System;

namespace Line_Comparison_Oops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Line Comparison Program!");

            LineCompare obj = new LineCompare();

            obj.CompareLines();
        }
    }
}