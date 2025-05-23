using TheBizarreJourney.Weapons;

namespace TheBizarreJourney.Weaknesses;

public abstract class Weakness
{
    public abstract string Name { get; }
    public abstract List<object> Effects { get; }
    protected abstract double DamageIncreaseFactor { get; }

    public void ModifyAttack(Attack attack)
    {
        attack.Damage = (int)(attack.Damage * DamageIncreaseFactor);
        attack.Weaknesses.Add(this);
    }
}