
namespace Assignment12
{
    internal class Invoice
    {
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }

        public double TotalAmount
        {
            get
            {
                return Quantity * UnitPrice;
            }
        }

        public Invoice(string itemName, int quantity, double unitPrice)
        {
            ItemName = itemName;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }

    }
}
