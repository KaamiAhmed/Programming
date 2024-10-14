namespace Assignment5
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
            Console.Write("Original value: ");
            int value = int.Parse(Console.ReadLine());

            ModifyByValue(value);
            Console.WriteLine($"Value after ModifyByValue: {value}");

            ModifyByReference(ref value);
            Console.WriteLine($"Value after ModifyByReference: {value}");
        }

        void ModifyByValue(int value)
        {
            value += 10;
        }

        void ModifyByReference(ref int value)
        {
            value += 10;
        }
    }
}
