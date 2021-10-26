using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAttack : AttackDecorator
{
    private readonly int fireDamage = 50;

 
    public FireAttack(IAttacker _attacker, int bonusDamage) : base(_attacker)
    {
        this.fireDamage = bonusDamage;
    }

    protected override void Modify()
    {
        _attacker.AddDamage(fireDamage, "Fuego");
    }
    

}
