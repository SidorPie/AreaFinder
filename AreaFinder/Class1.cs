using System;

namespace AreaFinder
{
    public interface iArea
    {
        double SearchArea();
    }

    public class Shape
    {
        protected iArea _area;

        public Shape(iArea area)
        {
            this._area = area;
        }
        public double Search()
        {
            return _area.SearchArea();
        }
    }

    public class Triangle : iArea
    {
        double a;
        double b;
        double c;
        double aTemp;
        double bTemp;
        double cTemp;
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public bool CheckTriangle()
        {
            aTemp = (a > b) ? b : a;
            bTemp = (a > b) ? a : b;

            if (bTemp < c)
            {
                cTemp = c;
            }
            else
            {
                cTemp = bTemp;
                bTemp = c;
            }
            if (((a + b) > c) && ((b + c) > a) && ((c + a) > b))
            {
                return true;
            }
            else
            if ((a == b) && (b == c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SearchArea()
        {
            double p = (a + b + c) / 2;
            double S = 0;

            if (CheckTriangle())
            {

                if (Math.Pow(cTemp, 2) == (Math.Pow(bTemp, 2) + Math.Pow(aTemp, 2)))
                {
                    S = ((p - aTemp) * (p - bTemp));
                }
                else
                {
                    S = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
                }
            }
            return S;
        }
    }
    public class Circle : iArea
    {
        double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double SearchArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
