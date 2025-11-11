class Program
{
    public static void Main()
    {
        //Console.WriteLine("Bonjour tout le monde");
        Planet mercury = new Planet();
        mercury._name = "Mercury";
        mercury._diameter = 1234.343;

        //mercury.DisplayPlanetInformation();
        Planet venus = new Planet();
        venus._name = "Venus";
        venus._diameter = 12343242.343;

        //venus.DisplayPlanetInformation();

        Planet earth = new Planet();
        earth._name = "Earth";
        earth._diameter = 12351231.1321;

        //earth.DisplayPlanetInformation();

        SolarSystem solarSystem = new SolarSystem();
        solarSystem._solarSystem.Add(mercury);
        solarSystem._solarSystem.Add(venus);
        solarSystem._solarSystem.Add(earth);
        solarSystem.DisplaySolarSystem();
    }
}