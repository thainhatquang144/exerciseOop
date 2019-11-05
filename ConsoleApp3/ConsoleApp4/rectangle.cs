using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Mytriangle
    {
        private MyPoint v1;
        private MyPoint v2;
        private MyPoint v3;

        public Mytriangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            v1 = new MyPoint(x1, y1);
            v2 = new MyPoint(x2, y2);
            v3 = new MyPoint(x3, y3);
        }
        public Mytriangle(MyPoint v1, MyPoint v2, MyPoint v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }
        public override string ToString()
        {
            return string.Format("MyTriangle[v1={0},v2={1},v3={2}]", this.v1, this.v2, this.v3);
            //return base.ToString();
        }
        public double getPerimeter()
        {
            return v1.Distance() + v2.Distance() + v3.Distance();
        }
        public string getType()
        {
            string result = "";
            if (v1.Distance(v2) == v2.Distance(v3) && v1.Distance(v2) == v1.Distance(v3) && v1.Distance(v3) == v2.Distance(v3))
                result = "equilateral";
            else if (v1.Distance(v2) == v2.Distance(v3) || v1.Distance(v2) == v1.Distance(v3) || v1.Distance(v3) == v2.Distance(v3))
                result = "isosceles";
            else if (v1.Distance(v2) != v2.Distance(v3) && v1.Distance(v2) != v1.Distance(v3) && v1.Distance(v3) != v2.Distance(v3))
                result = "scalene";
            return result;

        }
    }
}