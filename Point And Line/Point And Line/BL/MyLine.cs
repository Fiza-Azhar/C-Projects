using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_And_Line.BL
{
    class MyLine
    {
        private MyPoint Begin;
        private MyPoint End;
        public MyLine()
        {

        }

        public MyLine(MyPoint Begin, MyPoint End)
        {
            this.Begin = Begin;
            this.End = End;
        }

        internal MyPoint MyPoint
        {
            get => default;
            set
            {
            }
        }

        internal MyPoint MyPoint1
        {
            get => default;
            set
            {
            }
        }

        internal MyPoint MyPoint2
        {
            get => default;
            set
            {
            }
        }

        public MyPoint getBegin()
        {
            return Begin;
        }

        public MyPoint getEnd()
        {
            return End;
        }

        public void setBegin(MyPoint Begin)
        {
            this.Begin = Begin;
        }

        public void setEnd(MyPoint End)
        {
            this.End = End;
        }

        public double getLength()
        {
            double y1 = Math.Pow((Begin.getY() - End.getY()), 2);
            double x1 = Math.Pow((Begin.getX() - End.getX()), 2);
            double length = Math.Sqrt(x1 + y1);
            return length;
        }

        public double getGradient()
        {
            double y1 = End.getY() - Begin.getY();
            double x1 = End.getX() - Begin.getX();
            double gradient = (y1 / x1);
            return gradient;
        }
    }
}
