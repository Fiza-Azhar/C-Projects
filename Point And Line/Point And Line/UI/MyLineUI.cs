using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point_And_Line.BL;
using Point_And_Line.DL;
namespace Point_And_Line.UI
{
    class MyLineUI
    {
        public static MyLine AddLine()
        {
            Console.WriteLine("Enter x coordinate for start: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y coordinate for start");
            int y = int.Parse(Console.ReadLine());
            MyPoint start = new MyPoint(x, y);
            Console.WriteLine("Enter x coordinate ending: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y coordinate for ending");
            y = int.Parse(Console.ReadLine());
            MyPoint end = new MyPoint(x, y);
            MyLine line = new MyLine(start, end);
            return line;
        }
    }
}
