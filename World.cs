using TheBizarreJourney.Tiles;

namespace TheBizarreJourney;

public class World
{
    public World(int width, int height)
    {
        Tile[,] tilemap = new Tile[width, height];
        Tilemap = tilemap;
    }

    public Tile[,] Tilemap { get; private set; }
}