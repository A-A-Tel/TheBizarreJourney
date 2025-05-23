using TheBizarreJourney.Effects;
using TheBizarreJourney.Weaknesses;
using TheBizarreJourney.Weapons;

namespace TheBizarreJourney.Entities;

public abstract class Entity
{
    private int _weaponsIndex = 0;

    protected Entity(string name, int[] location)
    {
        Name = name;
        Location = location;
    }

    public string Name { get; }

    public int[] Location { get; set; }

    public List<Weapon> Weapons { get; } = [new FistWeapon()];
    public List<Effect> Effects { get; } = [];

    public virtual List<Weakness> Weaknesses { get; } = [];

    public int MaxHealth { get; protected set; }

    public int Health { get; set; }

    public virtual void AttackEntity(Entity entity)
    {
        Attack attack = Weapons[_weaponsIndex].GenerateAttack();

        foreach (Effect effect in Effects)
        {
            effect.ModifyAttack(attack);
        }
        
        entity.ReceiveAttack(attack);
    }

    public void ReceiveAttack(Attack attack)
    {
        foreach (Weakness selfWeakness in Weaknesses)
        {
            foreach (Weakness attackWeakness in attack.Weaknesses)
            {
                if (attackWeakness.GetType() == selfWeakness.GetType())
                {
                    attackWeakness.ModifyAttack(attack);

                    foreach (Effect effect in attackWeakness.Effects)
                    {
                        Effects.Add(effect);
                    }
                    
                    break;
                }
            }
        }
        Health -= attack.Damage;
    }

    public void EndTurn()
    {
        foreach (Effect effect in Effects)
        {
            effect.ModifyEntity(this);
        }
    }
}