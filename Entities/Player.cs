namespace TheBizarreJourney.Entities;

public class Player : Entity
{
    public Player(string name, int[] location) : base(name, location)
    {
        MaxHealth = 250;
        Health = MaxHealth;
    }
}