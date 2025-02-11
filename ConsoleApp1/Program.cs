using ConsoleApp1.repositoy;
Console.WriteLine("welcome to magie de verzameling");
Console.WriteLine("choose your deck");
PickCommander();
void PickCommander()
{
    CommanderRepository commanderrepository = new CommanderRepository();
    foreach (var commander in commanderrepository.commanders)
    {
        Console.WriteLine(commander.Name);
    }
    string choice = Console.ReadLine();
    foreach (var commander in commanderrepository.commanders)
    {
        if (choice == commander.Name)
        {
            Console.WriteLine($"you have chosen {choice}");
        }
    }
}