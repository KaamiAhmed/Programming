namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            Rectangle rectangle = new Rectangle();
            Console.Write("Enter width: ");
            rectangle.width = double.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            rectangle.height = double.Parse(Console.ReadLine());

           
            double area = rectangle.CalculateArea();
            double perimeter = rectangle.CalculatePerimeter();

            Console.WriteLine($"Area: {area}");
            Console.WriteLine($"Perimeter: {perimeter}");
        }
    }

}