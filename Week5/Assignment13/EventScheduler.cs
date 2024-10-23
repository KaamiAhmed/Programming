
namespace Assignment13
{
    internal class EventScheduler
    {
        public Event[] Events;
        public int NrOfEvents;

        public EventScheduler(int capacity)
        {
            Events = new Event[capacity];
            NrOfEvents = 0;
        }

        public void AddEvent(Event @event)
        {
            Events[NrOfEvents] = @event;
            NrOfEvents++;
            Console.WriteLine("\nEvent added to Scheduler");
        }

        public void DisplayEvents()
        {
            for (int i = 0; i < Events.Length; i++) 
            {
                Console.WriteLine($"{i + 1}. {Events[i].EventName} on {Events[i].Date} at {Events[i].Location}");
            }
        }
    }
}