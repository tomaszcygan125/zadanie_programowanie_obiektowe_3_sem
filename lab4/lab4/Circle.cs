using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    internal class Circle :Shape
    {
        public Circle(double X, double Y, double Width, double Height)
        {
            this.X = X;
            this.Y = Y;
            this.Width = Width;
            this.Height = Height;
        }
        public override void Draw()
        {
            Console.WriteLine("Circle");
        }
    }
}
