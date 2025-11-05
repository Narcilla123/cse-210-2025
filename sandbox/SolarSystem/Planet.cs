class Planet
{
    public string _name = "";
    public double _parameter;

    public void DisplayPlanetInformation()
    {
        Console.WriteLine($"THe planet name: {_name}, diameter: {_parameter}");
    }
}