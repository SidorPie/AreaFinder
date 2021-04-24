using System;
using System.Linq;

namespace AreaFinder
{
    public class Triangle : IArea
    {
        private readonly double[] _parameters;
        private double A;
        private double B;
        private double C;

        public Triangle(params double[] parameters)
        {
            _parameters = parameters;
            var temp = parameters.ToList();
            A = temp.Max();
            temp.Remove(A);
            C = temp.Min();
            temp.Remove(C);
            B = temp.First();

        }

        public double SearchArea()
        {
            double P = (A + B + C) / 2;
            double S = 0;
            S = Math.Sqrt((P * (P - A) * (P - B) * (P - C)));
            return S;
        }
    }


    public class Circle : IArea
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }
        public double SearchArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}

