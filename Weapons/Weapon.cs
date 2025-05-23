using TheBizarreJourney.Weaknesses;

namespace TheBizarreJourney.Weapons;

public abstract class Weapon
{
    public abstract string Name { get; }
    public abstract int Damage { get; }
    public abstract List<Weakness> Weaknesses { get; }

    public Attack GenerateAttack()
    {
        return new Attack(Damage, Weaknesses);
    }
}