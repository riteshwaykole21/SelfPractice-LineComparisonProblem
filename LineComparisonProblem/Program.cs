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
            CalculateLenght calculateLenght = new CalculateLenght(1, 4, 2, 8);
            calculateLenght.LenghtofLine();
            Console.ReadLine();
        }
    }
}
