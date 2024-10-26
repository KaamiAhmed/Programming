namespace Assignment9
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
            try
            {
                Console.Write("Enter width: ");
                double width = double.Parse(Console.ReadLine());
                Console.Write("Enter height: ");
                double height = double.Parse(Console.ReadLine());

                Rectangle rectangle = new Rectangle(width, height);

                Console.WriteLine("\nRectangle details:");
                Console.WriteLine($"Width: {rectangle.Width}");
                Console.WriteLine($"Area: {rectangle.Height}");
                Console.WriteLine($"Area: {rectangle.Area}");
                Console.WriteLine($"Perimeter: {rectangle.Perimeter}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error");
            }
        }
    }
}
