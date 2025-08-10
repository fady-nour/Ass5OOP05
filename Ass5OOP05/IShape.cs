using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass5OOP05
{
    #region Q1
    internal interface IShape
    { double Area { get; }
        void DisplayShapeInfo();

    }
    internal interface ICircle : IShape
    {
        double Radius { get; set; }
    }
    internal interface IRectangle : IShape
    {
        double Width { get; set; }
        double Height { get; set; }

    }
    public class Circle : ICircle
    {
        public double Radius { get; set; }
        public double Area => Math.PI * Radius * Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle: Radius = {Radius}, Area = {Area:F2}");
        }
    }

    public class Rectangle : IRectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Area => Width * Height;

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle: Width = {Width}, Height = {Height}, Area = {Area:F2}");
        }
    }
    #endregion
}
