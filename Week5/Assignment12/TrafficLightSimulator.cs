
namespace Assignment12
{
    internal class TrafficLightSimulator
    {
        public TrafficLight CurrentLight;

        public TrafficLightSimulator()
        {
            CurrentLight = TrafficLight.Red;
        }

        public void SetLight(TrafficLight light)
        {
            CurrentLight = light;
            Console.WriteLine($"Changing light to {light}...");
        }

        public void DisplayCurrentLight()
        {
            Console.WriteLine($"Current traffic light: {CurrentLight}");
        }
    }
}
