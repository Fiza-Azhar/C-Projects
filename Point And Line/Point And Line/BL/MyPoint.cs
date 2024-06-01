using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_And_Line.BL
{
    class MyPoint
    {
        private int x;
        private int y;
        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }
        public MyPoint()
        {
            x = 0;
            y = 0;
        }
        public void setX(int x)
        {
            this.x = x;
        }

        public void setY(int y)
        {
            this.y = y;
        }
        public void setXY(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public double distanceWithCords(int x, int y)
        {
            double xSquare = Math.Pow((this.x - x), 2);
            double ySquare = Math.Pow((this.y - y), 2);
            double distance = Math.Sqrt(xSquare + ySquare);
            return distance;
        }

        public double distanceWithObject(MyPoint another)
        {
            double Xsquare = Math.Pow((this.x - another.x), 2);
            double Ysquare = Math.Pow((this.y - another.y), 2);
            double dis = Math.Sqrt(Xsquare + Ysquare);
            return dis;

        }
        public double distanceFromZero()
        {
            double Xsqr = Math.Pow(this.x , 2);
            double Ysqr = Math.Pow(this.y, 2);
            double dis = Math.Sqrt(Xsqr + Ysqr);
            return dis;
        }
    }
}
