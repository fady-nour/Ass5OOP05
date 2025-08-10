using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass5OOP05
{
    #region Q1
    internal interface IShape
    {
        double Area { get; }
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
    #region Q2
    interface IAuthenticationService
    {
        bool AuthenticateUser(string Username, string Password);
        bool AuthorizeUser(string Username, string Role);
    }
    public class BasicAuthenticationService : IAuthenticationService
    {
        string username { get; set; }
        string passeord { get; set; }
        string role { get; set; }
        public BasicAuthenticationService(string username, string passeord, string role)
        {
            this.username = username;
            this.passeord = passeord;
            this.role = role;
        }
        public bool AuthenticateUser(string Username, string Password)
        {
            return Username == username && Password == Password;
        }


        public bool AuthorizeUser(string Username, string Role)
        {
            return Username == username && Role == role;
        }
    }
    #endregion
    #region Q 3
    interface INotificationService
    {
        void SendNotification(string recipient, string message);
    }
    public class EmailNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"[Email] To: {recipient} | Message: {message}");
        }
    }

    public class SmsNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"[SMS] To: {recipient} | Message: {message}");
        }
    }

    public class PushNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"[Push Notification] To: {recipient} | Message: {message}");
        }
    }
    #endregion
}

