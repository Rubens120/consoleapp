namespace ConsoleApp1;

public class Commanders
{
    public string Color { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int ManaValue { get; set; }

    public Commanders(string color, string name, string description, int manaValue)
    {
        this.Color = color;
        this.Name = name;
        this.Description = description;
        this.ManaValue = manaValue;
    }

}