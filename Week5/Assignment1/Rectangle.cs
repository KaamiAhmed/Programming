
namespace Assignment1
{
    internal class Rectangle
    {
        
        public double width, height;

        
        public double CalculateArea()
        {
            double area = width * height;
            return area;
        }

        public double CalculatePerimeter()
        {
            double perimeter = 2 * (width + height);
            return perimeter;
        }
    }

}
