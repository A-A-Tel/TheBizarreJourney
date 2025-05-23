using TheBizarreJourney.Entities;

namespace TheBizarreJourney.Tiles;

public class EmptyTile : Tile
{
    public EmptyTile(int[] location) : base(location)
    {
    }

    public override bool Enterable => true;

    public override void PlayerEnterAction(Player player)
    {
        Console.WriteLine("You have now entered an empty space.");
        player.Location = Location;
    }
}