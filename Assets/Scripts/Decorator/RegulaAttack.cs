using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegulaAttack : MonoBehaviour, IAttacker
{


    private readonly int damage = 20;
    
    public RegulaAttack(int _damage)
    {
        damage = _damage;
    }


    public void MoveToTarget(float speed, Transform endTarget)
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, endTarget.position, step);
    }

    public void MakeDamage(TargetEnemy targetEnemy)
    {
        targetEnemy.DamageRecieve(damage, "Regular");
    }

}
