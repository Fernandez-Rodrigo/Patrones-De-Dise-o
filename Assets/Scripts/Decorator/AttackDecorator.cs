using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AttackDecorator : MonoBehaviour, IAttacker
{

    private readonly IAttacker _attacker;

    protected AttackDecorator(IAttacker attacker)
    {
        _attacker = attacker;
    }

    public virtual void MakeDamage(TargetEnemy targetEnemy)
    {
        _attacker.MakeDamage(targetEnemy);
       
    }

    public void MoveToTarget(float speed, Transform endTarget)
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, endTarget.position, step);
    }
}
