using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class MyCircle
    {
        private MyPoint center;
        private int radius = 1;
        MyCircle()
        {

        }
        MyCircle(int x,int y,int radius)
        {
            this.radius = radius;
            center = new MyPoint(x, y);
        }
        MyCircle(MyPoint center,int radius)
        {
            this.center = center;
            this.radius = radius;
        }
        public int getRadius()
        {
            return radius;
        }
        public void setRadius(int radius)
        {
            this.radius = radius;
            
        }
        public MyPoint getColor()
        {
            return center;
        }
        public void setColor(MyPoint center)
        {
            this.center = center;
        }
        public int getCenterX()
        {
            return center.getX();
        }
        public void setCenteX(int x)
        {
            center.setX(x);
        }
        public int getCenterY()
        {
            return center.getY();
        }
        public void setCenterY(int y)
        {
            center.setY(y);
        }
        public int[] getCenterXY()
        {
            int[] cexy = new int[2];
            cexy[0] = this.getCenterX();
            cexy[1] = this.getCenterY();
            return cexy;
        }
        public void setCenterXY(int x, int y)
        {
            setCenteX(x);
            setCenterY(y);
        }
        public override string ToString()
        {
            return string.Format("MyCircle[radius = {0},center = {1}", this.radius, this.center);
            //return base.ToString();
        }
        public double getArea()
        {
            return radius * radius * Math.PI;
        }
        public double getCircumference()
        {
            return radius * 2 * Math.PI;
        }
        public double distance(MyCircle point)
        {
            return center.Distance(point.center);
        }
    }
}
