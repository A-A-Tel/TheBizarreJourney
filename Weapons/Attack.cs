using TheBizarreJourney.Effects;
using TheBizarreJourney.Weaknesses;

namespace TheBizarreJourney.Weapons;

public class Attack
{
    public Attack(int damage, List<Weakness> weaknesses)
    {
        Damage = damage;
        Weaknesses = weaknesses;
    }

    public int Damage { get; set; }
    public List<Weakness> Weaknesses { get; set; }
    public List<Effect> Effects { get; set; } = [];
}