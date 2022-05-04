using RectangleApp.Model;
using System;

namespace RectangleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Rectangle.length = 40;
            Rectangle.width = 30;

            Console.WriteLine(Rectangle.Calculate_Area(Rectangle.width,Rectangle.length).ToString());

            Rectangle.length = 60;
            Rectangle.width = 90;

            Console.WriteLine(Rectangle.Calculate_Area(Rectangle.width, Rectangle.length).ToString());
            Console.ReadKey();
        }
    }
}
