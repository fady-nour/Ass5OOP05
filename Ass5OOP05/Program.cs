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
            #region Q2
            IAuthenticationService authService = new BasicAuthenticationService("Admin","4455","admin");
            if (authService.AuthenticateUser("Amin", "4455") == true)
            {
                Console.WriteLine("user is authenticate correctly");

            }
            else
            {
                Console.WriteLine("NOT CORRECT");

            }
            if (authService.AuthenticateUser("Amin", "admin") == true)
            {
                Console.WriteLine("user is authorized correctly");

            }
            else
            {
                Console.WriteLine("NOT CORRECT");

            }
            #endregion
        }
    }
}
