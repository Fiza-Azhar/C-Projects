using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point_And_Line.BL;
using System.IO;
namespace Point_And_Line.DL
{
    class MyPointDL
    {
        public static List<MyPoint> Points = new List<MyPoint>();

        internal MyPoint MyPoint
        {
            get => default;
            set
            {
            }
        }

        public static void addIntoList(MyPoint p)
        {
            Points.Add(p);
        }
    }
}
