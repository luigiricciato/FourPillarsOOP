using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourPillarsOOP.Polymorphism
{
    internal abstract class Shape
    {
        public abstract double GetArea();
    }

    internal class Rectangle : Shape
    {
        private readonly double _width;
        private readonly double _height;

        internal Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }

        public override double GetArea()
        {
            return _width * _height;
        }
    }

    internal class Square : Rectangle 
    {
        internal Square(double length)
            : base(length, length)
        {
        }
    }

    internal class Circle : Shape
    {
        private readonly double _radius;

        internal Circle(double radius)
        {
            _radius = radius;
        }

        public override double GetArea()
        {
            return _radius * _radius * Math.PI;
        }
    }
}
