class Program
{
    public static void Main()
    {
        //Console.WriteLine("Bonjour tout le monde");
        Planet mercury = new Planet();
        mercury._name = "Mercury";
        mercury._parameter = 1234.343;

        //mercury.DisplayPlanetInformation();
        Planet venus = new Planet();
        venus._name = "Venus";
        venus._parameter = 12343242.343;

        //venus.DisplayPlanetInformation();

        SolarSystem solarSystem = new SolarSystem();
        solarSystem._solarSystem.Add(mercury);
        solarSystem._solarSystem.Add(venus);
        solarSystem.DisplaySolarSystem();
    }
}