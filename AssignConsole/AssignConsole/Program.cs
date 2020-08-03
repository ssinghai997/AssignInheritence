using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;



namespace AbstractClassAssign
{
    abstract class Quadrilateral
    {
        public int length;



        public abstract double Area();
        public Quadrilateral()
        {



        }
        public Quadrilateral(int _length)
        {
            length = _length;
        }
    }
    class Square : Quadrilateral
    {



        public Square(int _length) : base(_length)
        {



        }
        public override double Area()
        {
            return length * length;
        }




    }
    class Rectangle : Quadrilateral
    {
        int breadth;

        public int IsSquare
        {
            get { return breadth; }
            set
            {
                if (value == length)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    breadth = value;
                }
            }
        }
        public Rectangle(int _length, int _breadth) : base(_length)
        {
            breadth = _breadth;
        }
        public override double Area()
        {
            return length * breadth;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Square sqr = new Square(4);
            Rectangle rect = new Rectangle(5, 6);
            Console.WriteLine("Area of Square is : {0} ", sqr.Area());
            Console.WriteLine("Area of Rectangle is : {0}", rect.Area());
            if (sqr.Area() > rect.Area())
            {
                Console.WriteLine("Square Area is greater than Rectangle Area");
            }
            else
            {
                Console.WriteLine("Rectangle Area is greater than Square Area");
            }




        }
    }
}