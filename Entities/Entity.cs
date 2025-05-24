namespace TheBizarreJourney.Entities;

public abstract class Entity
{
    public int MaxHealth { get; set; }
    public int Health { get; set; }
    
    public abstract string Name { get; }

    public abstract void ProcessAttack(Attack attack);
}