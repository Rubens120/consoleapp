namespace ConsoleApp1.repositoy;

public class CommanderRepository
{
    public List<Commanders> commanders { get; set; } = new List<Commanders>()
    {
        new Commanders("Green", "life", "enchantment", 4),
        new Commanders("Red", "Dog", "Dog", 4),
    };

}