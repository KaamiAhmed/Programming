namespace Assignment13
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
            const int NrOfEvents = 2;
            EventScheduler eventScheduler = new EventScheduler(NrOfEvents);

            for (int i = 0; i < NrOfEvents; i++)
            {
                Console.Write("Enter event name: ");
                string eventName = Console.ReadLine();
                Console.Write("Enter event date(YYYY-MM-DD): ");
                string date = Console.ReadLine();
                Console.Write("Enter event location: ");
                string location = Console.ReadLine();

                Event events = new Event(eventName, date, location);
                eventScheduler.AddEvent(events);

                Console.WriteLine();
            }

            Console.WriteLine("\nScheduled Events: ");
            eventScheduler.DisplayEvents();
        }
    }
}
