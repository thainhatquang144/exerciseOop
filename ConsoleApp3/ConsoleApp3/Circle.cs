using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Circle
    {
        private double radius;
        private string color;

        public Circle()
        {
            radius = 1.0;
            color = "red";
        }
        public Circle(double r)
        {
            radius = r;
            color = "red";
        }
        public Circle(double r, string c)
        {
            radius = r;
            color = c;
        }
        public void setRadius(double NewRadius)
        {
            radius = NewRadius;
        }
        public void setColor(string NewColor)
        {
            color = NewColor;
        }
        public string getColor()
        {
            return color;
        }
        public double getCircumference()
        {
            return radius * 2 * Math.PI;
        }
        public double getRadius()
        {
            return radius;
        }
        public double getArea()
        {
            return radius * radius * Math.PI;
        }
        public override string ToString()
        {
            return String.Format("Circle [radius = {0},color = {1}]", getRadius(), getColor());
            return String.Format("Circle [radius = {0}]", getRadius());
            //return base.ToString();
        }
    }
}