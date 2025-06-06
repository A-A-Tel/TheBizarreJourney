namespace TheBizarreJourney.Weapons;

public abstract class Weapon
{
    public abstract string Name { get; }

    public abstract Attack GenerateAttack();
}