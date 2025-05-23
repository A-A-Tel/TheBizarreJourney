using TheBizarreJourney.Entities;
using TheBizarreJourney.Weapons;

namespace TheBizarreJourney.Effects;

public abstract class Effect
{
    public abstract string Name { get; }
    protected abstract string HealthTickMessage { get; }
    protected abstract string DamageTickMessage { get; }
    protected abstract double DamageIncreaseFactor { get; }
    protected abstract double HealthIncreaseFactor { get; }

    public void ModifyEntity(Entity entity)
    {
        Console.WriteLine(HealthTickMessage, entity.Name);
        entity.Health *= (int)(entity.Health * HealthIncreaseFactor);
    }

    public void ModifyAttack(Attack attack)
    {
        Console.WriteLine(DamageTickMessage, attack.Damage);
        attack.Damage = (int)(attack.Damage * DamageIncreaseFactor);
    }
}