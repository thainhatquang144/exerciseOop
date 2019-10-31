using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mypoint
{
    class MyPoint
    {
        private int x = 0;
            private int y=0;
            public MyPoint()
            {
                this.x = 0;
                this.y = 0;
            }
            public MyPoint(int x,int y)
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
            public void setX(int x)
            {
                this.x = x;
            }
            public void setY(int y)
            {
                this.y = y;
            }
            public int[]getXY()
            {
                int[] xy = new int[2];
                xy[0] = this.x;
                xy[1] = this.y;
                return xy;
            }
            public void setXY(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public override string ToString()
            {
                return string.Format("({0},{1}",this.x,this.y);
            }
        public double Distance(int x,int y)
        {
            int deltax = this.x - x;
            int deltay=this.y-y;
            return Math.Sqrt(((deltax)*(deltax))+((deltay)+(deltay)));
        }
        public double Distance(MyPoint point)
        {
            return Distance(point.x, point.y);
        }
        public double Distance()
        {
            return Distance(0, 0);
        }
    }
}
