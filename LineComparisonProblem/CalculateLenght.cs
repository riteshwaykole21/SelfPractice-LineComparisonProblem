using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    public class CalculateLenght
    {
        int x1,y1,x2,y2;
        public CalculateLenght(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }
        public void LenghtofLine()
        {
            double lenghtofline = Math.Sqrt(Math.Pow(x2-x1 ,2)) + Math.Pow(y2-y1 ,2);
            Console.WriteLine("Lenght of Line Is = " + lenghtofline);
        }
    }
}
