using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleApp.Model
{
    public class Rectangle
    {
        public static int width { get; set; } =0;

        public static int length { get; set; } = 0;

        public static int Calculate_Area(int width, int length)
        {
            return width * length;
        }
    }
}
