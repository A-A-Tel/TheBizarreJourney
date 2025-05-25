using TheBizarreJourney.Entities;

namespace TheBizarreJourney.Tiles;

public abstract class Tile
{
    public bool Entered { get; protected set; }
    public abstract bool Enterable { get; }

    public abstract void PlayerEnterAction(Player player);
}