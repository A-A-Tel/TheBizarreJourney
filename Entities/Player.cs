using TheBizarreJourney.Weapons;

namespace TheBizarreJourney.Entities;

public class Player : Entity
{
    public List<Weapon> Weapons { get; } = [];
    public int WeaponIndex { get; private set; }
    
    public override string Name { get; } = Console.ReadLine() ?? throw new NullReferenceException();
    
    public override void ProcessAttack(Attack attack)
    {
        throw new NotImplementedException();
    }
}