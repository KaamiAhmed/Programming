
namespace Assignment4
{
    internal class Circle
    {

        //const double Pi = 3.14;

        private double _radius;
        public double Area
        {
            get
            {
                return Math.PI * (_radius * _radius);
            }
        }

        public Circle(double radius)
        {
            _radius = radius;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Radius: {_radius}");
            Console.WriteLine($"Area: {Area:0.00}");
        }
    }
}
