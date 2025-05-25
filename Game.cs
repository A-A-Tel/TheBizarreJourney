using TheBizarreJourney.Entities;
using TheBizarreJourney.Tiles;

namespace TheBizarreJourney;

public class Game
{
    private readonly Tile[,] _world;
    private readonly Player _player;

    public Game(int width, int height)
    {
        Tile[,] world = new Tile[width, height];
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                world[i, j] = new EmptyTile();
            }
        }

        _world = world;

        Console.WriteLine("Enter your name...");
        _player = new Player();
    }

    public void StartGame()
    {
        Console.WriteLine("You find yourself in a dungeon of bizarre phenomenons.");
        Console.WriteLine("The entrance is closed off behind you, seems like you have to venture onwards.");
        PrintLine();
        while (true)
        {
            int[] loc = _player.Location;
            _world[loc[0], loc[1]].PlayerEnterAction(_player);

            Console.WriteLine("What action would you like to perform?");
            Console.WriteLine("MOVE to a different tile");
            switch (Input())
            {
                case "MOVE":
                    MoveAction();
                    break;
                case "STOP":
                    return;
            }
        }
    }

    private void MoveAction()
    {
        Console.WriteLine("In what Direction would you like to move?");
        Console.WriteLine("(NORTH, SOUTH, WEST, EAST)");
        switch (Input())
        {
            case "NORTH":
                Move([0, -1]);
                break;
            case "SOUTH":
                Move([0, 1]);
                break;
            case "EAST":
                Move([1, 0]);
                break;
            case "WEST":
                Move([-1, 0]);
                break;
        }
    }

    private bool Move(int[] direction)
    {
        int[] newLocation = [_player.Location[0] + direction[0], _player.Location[1] + direction[1]];

        if (newLocation[0] < 0 || newLocation[1] >= _world.GetLength(0) ||
            newLocation[1] < 0 || newLocation[1] >= _world.GetLength(1))
        {
            Console.WriteLine("That direction is invalid");
            return false;
        }

        Tile tile = _world[_player.Location[0], _player.Location[1]];

        if (!tile.Enterable)
        {
            Console.WriteLine("That tile is inaccessible");
            return false;
        }

        _player.Location = newLocation;
        return true;
    }


    private static string Input()
    {
        string input = Console.ReadLine() ?? throw new NullReferenceException();
        return input.Split(" ")[0].ToUpper();
    }

    private static void PrintLine()
    {
        Console.WriteLine("-----------------------");
    }
}