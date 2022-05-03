namespace AreaCalculation
{
    public static class Area
    {
        public static double AreaCircle(double radius)
        {
            if (radius < 0)
            {
                return -1;
            }

            if (radius == 0)
            {
                return 0;
            }

            const double Pi = Math.PI;
            return Pi * radius * radius;
        }
        public static double AreaTriangle(double a, double b, double c)
        {
            double p = (a + b + c) / 2.0;
            double squareArea = p * (p - a) * (p - b) * (p - c);
            if (squareArea < 0)
            {
                return -1;
            }
            return Math.Sqrt(squareArea);
        }
        public static bool IsExistTriangle(double a, double b, double c)
        {
            return (a < b + c) && (b < a + c) && (c < a + b);
        }
        public static bool IsRectangularTriangle(double a, double b, double c)
        {
            return IsExistTriangle(a, b, c) &&
                  (Math.Abs(a * a - (b * b + c * c)) < 0.1
                || Math.Abs(b * b - (a * a + c * c)) < 0.1
                || Math.Abs(c * c - (b * b + a * a)) < 0.1);
        }

    }
}
