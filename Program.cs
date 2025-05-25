namespace TheBizarreJourney;

internal static class Program
{
    private static void Main(string[] args)
    {
        Game game = new Game(12, 13);
        
        game.StartGame();
    }
}