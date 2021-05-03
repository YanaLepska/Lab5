using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Point
    {
        public double X1 { get; private set; }
        public double X2 { get; private set; }
        public double Y { get; private set; }

        public Point(double X1, double X2)
        {
            this.X1 = X1;
            this.X2 = X2;
            this.Y = calculateY(this.X1, this.X2);
        }
        private double calculateY(double X1, double X2)
        {
            double Y = 0;
              
            Y = Math.Sqrt(56 * X1 + ((X1+X2+ Math.Sin(gradToRadians(X1 * X2)) /(5 - Math.Cos(gradToRadians(Math.Pow(X2, 2)))))));

            return Y;
        }

        private double gradToRadians(double angle)
        {
            return angle * Math.PI / 180;
        }

        public override string ToString()
        {
            return "Y = " + this.Y.ToString("0.00000") + " X1 = " + this.X1.ToString("0.00000") + " X2 = " + this.X2.ToString("0.00000");
        }
    }
}
