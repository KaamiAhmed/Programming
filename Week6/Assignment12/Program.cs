namespace Assignment12
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
            Console.Write("Enter item name: ");
            string itemName = Console.ReadLine();
            Console.Write("Enter quantity: ");
            int quantity = int.Parse(Console.ReadLine());
            Console.Write("Enter unit price: ");
            double unitPrice = double.Parse(Console.ReadLine());

            Invoice invoice = new Invoice(itemName, quantity, unitPrice);

            Console.WriteLine($"\nInvoice details:");
            Console.WriteLine($"Item name: {invoice.ItemName}");
            Console.WriteLine($"Quantity: {invoice.Quantity}");
            Console.WriteLine($"Unit price: {invoice.UnitPrice}");
            Console.WriteLine($"Total amount: {invoice.TotalAmount}");
        }
    }
}
