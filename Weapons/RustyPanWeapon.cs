using TheBizarreJourney.Weaknesses;

namespace TheBizarreJourney.Weapons;

public class RustyPanWeapon : Weapon
{
    public override string Name => "The legendary Rusty-Pan!";
    public override int Damage => 50;
    public override List<Weakness> Weaknesses => [new RustWeakness()];
}