using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point_And_Line.BL;
namespace Point_And_Line.UI
{
    class MyPointUI
    {
        public static MyLine UpdateStartPoint(MyLine line)
        {
            Console.WriteLine("Enter new X co-ordinate");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter new Y co-ordinate");
            int b = int.Parse(Console.ReadLine());
            MyPoint p = new MyPoint();
            p.setX(a);
            p.setY(b);
            line.setBegin(p);
            return line;
        }
        public static MyLine UpdateEndPoint(MyLine line)
        {
            Console.WriteLine("Enter new X co-ordinate");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y co-ordinate");
            int b = int.Parse(Console.ReadLine());
            MyPoint p = new MyPoint();
            p.setX(a);
            p.setY(b);
            line.setEnd(p);
            return line;
        }
        public static void showBegin(MyLine line)
        {
            MyPoint p = line.getBegin();
            int x = p.getX();
            int y = p.getY();
            Console.WriteLine("X co-ordinate of begin point is " + x);
            Console.WriteLine("Y co-ordinate of begin point is " + y);
        }

        public static void showEnd(MyLine line)
        {
            MyPoint p = line.getEnd();
            int x = p.getX();
            int y = p.getY();
            Console.WriteLine("X co-ordinate of End point is " + x);
            Console.WriteLine("Y co-ordinate of End point is " + y);
        }
    }
}
