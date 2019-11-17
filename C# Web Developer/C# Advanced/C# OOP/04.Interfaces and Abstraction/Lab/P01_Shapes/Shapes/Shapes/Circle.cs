﻿namespace Shapes
{
    using System;

    public class Circle : IDrawable
    {
        //------------Fields---------------
        private int radius;

        //---------Constructors------------
        public Circle(int radius)
        {
            this.Radius = radius;
        }
        //----------Properties-------------
        public int Radius
        {
            get { return this.radius; }
            private set { this.radius = value; }
        }
        //------------Methods--------------
        public void Draw()
        {
            double rIn = this.Radius - 0.4;
            double rOut = this.Radius + 0.4;
            for (double y = this.Radius; y >= -this.Radius; --y)
            {
                for (double x = -this.Radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}