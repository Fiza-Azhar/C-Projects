using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point_And_Line.BL;
using Point_And_Line.DL;
using Point_And_Line.UI;
namespace Point_And_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLine line = new MyLine();
            do
            {
                int opt = MenuUI.MainMenu();
                if (opt == 1)
                {
                    line = MyLineUI.AddLine();
                }
                else if (opt == 2)
                {
                    line = MyPointUI.UpdateStartPoint(line);
                }
                else if (opt == 3)
                {
                    line = MyPointUI.UpdateEndPoint(line);
                }
                else if (opt == 4)
                {
                    MyPointUI.showBegin(line);
                }
                else if (opt == 5)
                {
                    MyPointUI.showEnd(line);
                }
                else if (opt == 6)
                {
                    double Lenght = line.getLength();
                    Console.WriteLine("Lenght of line is: " + Lenght);
                }
                else if (opt == 7)
                {
                    double Gradient = line.getGradient();
                    Console.WriteLine("Gradient of line is: " + Gradient);
                }
                else if (opt == 8)
                {
                    double Distance = line.getBegin().distanceFromZero();
                    Console.WriteLine("Distance of begin point from zero coordinate: " + Distance);
                }
                else if (opt == 9)
                {
                    double Distance = line.getEnd().distanceFromZero();
                    Console.WriteLine("distance of end points from zero coordinate: " + Distance);
                }
                else if (opt == 10)
                {
                    MyPoint begin = line.getBegin();
                    MyPoint end = line.getEnd();
                    break;
                }
                else
                {
                    Console.WriteLine("You chose wrong option....");
                }
                MenuUI.ClearScreen();
            } while (true);
        }
    }
}
