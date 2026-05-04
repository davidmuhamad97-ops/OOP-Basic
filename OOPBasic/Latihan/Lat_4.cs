using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasic.Latihan
{
    public class Lat_4
    {
        public static void main()
        {
            Circle circle = new Circle(5);
            Console.WriteLine(circle.describe());
        }
    }

    class Shape
    {
        protected string name;

        public virtual double Area()
        {
            return 0;
        }

        public virtual double Perimeter()
        {
            return 0;
        }

        public string describe()
        {
            return $"Shape: {this.name}\n" +
                $"Luas : {this.Area()}\n" +
                $"Keliling : {this.Perimeter()}";
        }
    }

    class Circle : Shape
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public Circle(double radius)
        {
            this.radius = radius;
            this.name = "Circle";
        }
        public override double Area()
        {
            return Math.PI * radius * radius;
        }
        public override double Perimeter() 
        {
            return 2 * Math.PI * radius;
        }
    }
}
