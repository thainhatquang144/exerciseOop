using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Circle c1 = new Circle();
            //Console.WriteLine("Circumference of Circle is " + c1.getCircumference());
            //Console.WriteLine(c1.ToString());

            Rectangle r1 = new Rectangle();
            r1.setLength(5);
            r1.setWidth(5);
            Console.WriteLine("Perimeter of Rectangle is " + r1.getPerimeter());
            Console.WriteLine("Area of Rectangle is " + r1.getArea());
            Console.WriteLine(r1.ToString());
        
            //   c1.setRadius(5.0);
         //   c1.setColor("Brown");
         //   Console.WriteLine("The circle has radius of "
         //+ c1.getRadius() + " and area of " + c1.getArea() + " and color is " + c1.getColor());
         //   Console.WriteLine();
         //   Circle c2 = new Circle(3);
         //   Console.WriteLine("The circle has radius of "
         //+ c2.getRadius() + " and area of " + c2.getArea());
         //   Console.WriteLine();
         //   Circle c3 = new Circle(3, "Orange");
         //   Console.WriteLine("The circle color is " + c3.getColor());
         //   Console.WriteLine(c3.ToString());

            //Employee e = new Employee(193,10,"nam","nhat");
            //e.setSalary(3);
            //Console.WriteLine(e.getAnnualSalary());


        }
    }
}