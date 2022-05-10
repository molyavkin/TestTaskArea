using System.ComponentModel.DataAnnotations;

namespace AreaCalculation
{
    public class Circle : IShapes
    {
        private double _radius;

        [Required]
        public double Radius
        {
            set
            {
                if (value >= 0)
                {
                    _radius = value;
                }
            }
            get
            {
                return _radius;
            }
        }

        public Circle(double radius)
        {
            _radius = radius;
        }


        public double GetArea()
        {
            if (_radius == 0)
            {
                return 0;
            }

            const double Pi = Math.PI;
            return Pi * _radius * _radius;
        }

    }
}
