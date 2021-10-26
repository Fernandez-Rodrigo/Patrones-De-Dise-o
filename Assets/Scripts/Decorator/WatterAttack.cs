using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatterAttack : AttackDecorator
{
    private readonly int waterDamage = 40;


    public WatterAttack(IAttacker _attacker, int bonusDamage) : base(_attacker)
    {
        this.waterDamage = bonusDamage;
    }

    protected override void Modify()
    {
        _attacker.AddDamage(waterDamage, "Agua");
    }

}
