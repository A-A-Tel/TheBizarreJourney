namespace TheBizarreJourney.Weaknesses;

public class RustWeakness : Weakness
{
    public override string Name => "The weakness of the Evil-Rust!";
    public override List<object> Effects => [];
    protected override double DamageIncreaseFactor => 1.5;
}