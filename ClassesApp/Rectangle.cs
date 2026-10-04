using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    internal class Rectangle
    {
        public const int NumberofCorners = 4;
        public readonly string color;

        public Rectangle(string color)
        {
            this.color = color;
        }
        public double width { get; set; }
        public double height { get; set; }
        public double Area { get {  return width * height; } } 

        public void displayDetails()
        {
            Console.WriteLine("Rectangle Color: " + color + ", Width: " + width + ", Height: " + height + ", Area: " + Area);
        }

    }

}
