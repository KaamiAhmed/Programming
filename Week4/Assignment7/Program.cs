namespace Assignment7
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
            bool[] seats = new bool[10];

            InitializeSeats(seats);

            Console.WriteLine("Seating arrangements: ");
            DisplaySeatingArrangement(seats);

            Console.Write("Enter the seat number to book(1-10): ");
            int seatNumber = int.Parse(Console.ReadLine());
            BookSeat(seats, seatNumber);

            Console.WriteLine("Current seating arrangements: ");
            DisplaySeatingArrangement(seats);
        }

        void InitializeSeats(bool[] seats)
        {
            Random random = new Random();
            for (int i = 0; i < seats.Length; i++)
            {
                seats[i] = random.Next(2) == 0;
            }
        }

        void DisplaySeatingArrangement(bool[] seats)
        {
            for (int i = 0; i < seats.Length; i++)
            {
                /*
                string availability = seats[i] ? "Available" : "Booked";
                Console.WriteLine($"Seat {i + 1}: {availability}");
                */
                if (seats[i])
                {
                    Console.WriteLine($"Seat {i + 1}: available");
                }
                else
                {
                    Console.WriteLine($"Seat {i + 1}: booked");
                }
            }
        }

        void BookSeat(bool[] seats, int seatNumber)
        {
            int index = seatNumber - 1;

            if (seats[index])
            {
                seats[index] = false;
                Console.WriteLine($"Seat {seatNumber} has been successfully booked.");  
            }
            else
            {
                Console.WriteLine($"Seat number {seatNumber} is already booked.");
            }
        }
    }
}