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
            TrafficLightSimulator simulator = new TrafficLightSimulator();

            simulator.DisplayCurrentLight();

            simulator.SetLight(TrafficLight.Yellow);
            simulator.DisplayCurrentLight();

            simulator.SetLight(TrafficLight.Green);
            simulator.DisplayCurrentLight();
        }
    }
}
