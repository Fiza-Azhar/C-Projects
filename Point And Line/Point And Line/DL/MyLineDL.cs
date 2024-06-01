using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point_And_Line.BL;
using System.IO;
namespace Point_And_Line.DL
{
    class MyLineDL
    {
        public static List<MyLine> Lines = new List<MyLine>();

        internal MyPoint MyPoint
        {
            get => default;
            set
            {
            }
        }

        internal MyLine MyLine
        {
            get => default;
            set
            {
            }
        }

        public static void AddIntoLineList(MyLine l)
        {
            Lines.Add(l);
        }
        public static void AddPointsIntoList()
        {
            for (int i = 0; i < MyPointDL.Points.Count; i++)
            {
                if (i % 2 == 0)
                {
                    MyPoint begin = MyPointDL.Points[i];
                    MyPoint end = MyPointDL.Points[i + 1];
                    MyLine l = new MyLine(begin, end);
                    AddIntoLineList(l);
                }
            }
        }
    }
}
