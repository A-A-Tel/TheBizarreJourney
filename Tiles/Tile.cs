namespace TheBizarreJourney.Tiles;

public abstract class Tile
{
    public bool Entered { get; protected set; }
    public abstract bool Enterable { get; protected set; }

    public abstract void PlayerEnterAction();
}