using TheBizarreJourney.Entities;

namespace TheBizarreJourney.Tiles;

public abstract class Tile
{
    protected Tile(int[] location)
    {
        Location = location;
    }

    protected bool Entered { get; set; } = false;

    public int[] Location { get; private set; }


    public abstract bool Enterable { get; }

    public abstract void PlayerEnterAction(Player player);
}