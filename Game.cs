using TheBizarreJourney.Entities;

namespace TheBizarreJourney;

public class Game
{
    private readonly World _world = new(12, 16);
    private Player _player;


    public static string GetInput()
    {
        Console.WriteLine("Enter an option...");
        return Console.ReadLine() ?? throw new NullReferenceException("Line not found!");
    }
}