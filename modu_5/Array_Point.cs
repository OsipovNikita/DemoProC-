using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
      struct Point
    {
        public double x;
        public double y;

        public Point(double xd, double yd)
        {
            x = xd;
            y = yd;
        }

        public void Mov(double xx, double yy)
        {
            x += xx;
            y += yy;
        }
    }
	public class Program
	{
		public static void Main(string[] args)
		{
		  Point p1;
		  p1.x = 2;
		  p1.y = 4;
		  Point[] mp = {p1, new Point(6,8)};
		  foreach(var it in mp){
		    Console.WriteLine("Hello, Point - {0}:{1} ", it.x, it.y);
		  }
			//Console.WriteLine("Hello, World! " + mp[1].x);
		}
	}
}