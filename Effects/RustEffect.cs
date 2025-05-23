namespace TheBizarreJourney.Effects;

public class RustEffect : Effect
{
    public override string Name => "The poison of the world's rust";

    protected override string HealthTickMessage =>
        "The rust has gotten the better of {0}, their health has dropped by 10%";

    protected override string DamageTickMessage => "The rust appears to have dropped the attack's damage to {0}";

    protected override double DamageIncreaseFactor => 0.9;

    protected override double HealthIncreaseFactor => 0.9;
}