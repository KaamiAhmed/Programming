
namespace Assignment9
{
    internal class Rectangle
    {
        private double _width;
        private double _height;

        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }

        public double Width
        {
            get 
            { 
                return _width; 
            }
            set 
            {
                if (value > 0)
                {
                    _width = value;
                }
                else
                    throw new ArgumentException("invalid");
            }
        }

        public double Height
        {
            get 
            { 
                return _height; 
            }
            set 
            {
                if (value > 0)
                {
                    _height = value;
                }
                else
                    throw new ArgumentException("Invalid input.");
            }
        }

        public double Area 
        { 
            get 
            { 
                return _width * _height; 
            } 
        }

        public double Perimeter 
        { 
            get 
            { 
                return 2 * (_width + _height); 
            } 
        }
    }
}