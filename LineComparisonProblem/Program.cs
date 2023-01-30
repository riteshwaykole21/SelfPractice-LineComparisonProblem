using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Line Comparison Problem");
            CalculateLenght calculateLenght_1 = new CalculateLenght(1, 4, 2, 8);
            double Line_1 = calculateLenght_1.LenghtofLine();
            Console.WriteLine("lenght of First Line = " + Line_1);
            //for Line 2 object
            CalculateLenght calculateLenght_2 = new CalculateLenght(5, 4, 2, 8);
            double Line_2 = calculateLenght_2.LenghtofLine();
            Console.WriteLine("Lenght Of Second Line =" + Line_2);
            //uc2 Equal method (given boolen condition)
            if (Line_1.Equals(Line_2))
            {
                Console.WriteLine("Both Lines Are Equal");
            }
            else
            {
                Console.WriteLine("Not Both Lines Are Equal");
                //To check which Line Is Greater By Compare To Method
                if (Line_1.CompareTo(Line_2) > 0)
                {
                    Console.WriteLine("Line 1 is Greater to Line 2");
                }
                else
                {
                    Console.WriteLine("Line 1 is Less than Line 2");
                }
                Console.ReadLine();
            }
        }
    }
}

