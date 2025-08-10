namespace Ass5OOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            ICircle circle = new Circle(5);
            circle.DisplayShapeInfo();

            IRectangle rectangle = new Rectangle(4, 6);
            rectangle.DisplayShapeInfo();
            #endregion
        }
    }
}
