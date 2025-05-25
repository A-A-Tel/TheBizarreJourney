using TheBizarreJourney.Entities;

namespace TheBizarreJourney.Tiles;

public class EmptyTile : Tile
{
    public override bool Enterable => true;
    public override void PlayerEnterAction(Player player)
    {
        Console.WriteLine("You have entered an empty space (" + player.Location[0] + ", " + player.Location[1] + ")");
    }
}