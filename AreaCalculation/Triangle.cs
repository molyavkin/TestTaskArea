using System.ComponentModel.DataAnnotations;

namespace AreaCalculation
{
    public class Triangle
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        [Required]
        public double SideA
        {
            set
            {
                if (value >= 0)
                {
                    _sideA = value;
                }
            }
        }
        [Required]
        public double SideB
        {
            set
            {
                if (value >= 0)
                {
                    _sideB = value;
                }
            }
        }
        [Required]
        public double SideC
        {
            set
            {
                if (value >= 0)
                {
                    _sideC = value;
                }
            }
        }
        public double GetArea()
        {
            double p = (_sideA + _sideB + _sideC) / 2.0;
            double squareArea = p * (p - _sideA) * (p - _sideB) * (p - _sideC);
            if (squareArea < 0)
            {
                return -1;
            }
            return Math.Sqrt(squareArea);
        }
        public bool IsRightAngled()
        {
            bool isExist = (_sideA <= _sideB + _sideC)
                        && (_sideB <= _sideA + _sideC)
                        && (_sideC <= _sideA + _sideB);
            return isExist &&
                  (Math.Abs(_sideA * _sideA - (_sideB * _sideB + _sideC * _sideC)) < 0.1
                || Math.Abs(_sideB * _sideB - (_sideA * _sideA + _sideC * _sideC)) < 0.1
                || Math.Abs(_sideC * _sideC - (_sideB * _sideB + _sideB * _sideB)) < 0.1);
        }

    }
}
/*
 * public static bool IsRectangularTriangle(double a, double b, double c)
        {
            return IsExistTriangle(a, b, c) &&
                  (Math.Abs(a * a - (b * b + c * c)) < 0.1
                || Math.Abs(b * b - (a * a + c * c)) < 0.1
                || Math.Abs(c * c - (b * b + a * a)) < 0.1);
        }
 */