using TheBizarreJourney.Entities;

namespace TheBizarreJourney.Tiles;

public class NullTile : Tile
{
    public NullTile(int[] location) : base(location)
    {
    }

    public override bool Enterable => false;

    public override void PlayerEnterAction(Player player)
    {
        throw new NotSupportedException("Empty tile is NOT enterable!");
    }
}