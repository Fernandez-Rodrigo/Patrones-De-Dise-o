using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AttackDecorator : IAttacker
{
    protected IAttacker _attacker;
    protected ITargetEnemy _enemy;

    public AttackDecorator(IAttacker specialAttack)
    {
        this._attacker = specialAttack;
    }

    public void MakeDamage(ITargetEnemy targetEnemy)
    {
       if (!_attacker.Equals(null))
       {
            _enemy = targetEnemy;
            Modify();
       }
    }


    protected abstract void Modify();
   
    public void AddDamage(int bonusDamage, string type) { }

}
