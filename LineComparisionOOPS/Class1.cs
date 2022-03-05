using System;
using System.Collections.Generic;
using System.Text;

namespace Line_Comparison_Oops
{
    class LineCompare
    {
        public double length1, length2;
        public double x1, x2, y1, y2;
        public double a1, a2, b1, b2;

        public void input()
        {
            
            Console.WriteLine("Enter co-ordinates of line1");
            Console.WriteLine("Enter point1 (x1, y1): ");
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter point2 (x2, y2): ");
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            //2nd co-ordinate
            Console.WriteLine("Enter co-ordinates of line2");
            Console.WriteLine("Enter point1 (a1, b1): ");
            a1 = double.Parse(Console.ReadLine());
            b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter point2 (a2, b2): ");
            a2 = double.Parse(Console.ReadLine());
            b2 = double.Parse(Console.ReadLine());
        }
        
        public void cal()
        {
            length1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Length1 =" + length1);
            length2 = Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2));
            Console.WriteLine("Length2 =" + length2);

        }


       
        public void CompareLines()
        {
            if (length1.Equals(length2))
            {
                Console.WriteLine("The length of two lines are equal");
            }
            else if (length1.CompareTo(length2) < 0)
            {
                Console.WriteLine("The length of line 1 is lesser than line 2");
            }
            else if (length1.CompareTo(length2) > 0)
            {
                Console.WriteLine("The length of line 1 is greater than line 2");
            }
        }
    }
}