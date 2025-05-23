using TheBizarreJourney.Weaknesses;

namespace TheBizarreJourney.Weapons;

public class FistWeapon : Weapon
{
    public override string Name => "The fists of Hercules";
    public override int Damage => 45;
    public override List<Weakness> Weaknesses => [];
}