namespace TheBizarreJourney.Entities;

public abstract class Enemy : Entity
{
    protected Enemy(string name, int[] location) : base(name, location)
    {
    }
}