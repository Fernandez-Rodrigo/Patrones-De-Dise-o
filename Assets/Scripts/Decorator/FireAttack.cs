using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAttack : AttackDecorator
{
    float speed = 90f;
    Transform target;
    private readonly int fireDamage = 50;

    private void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Finish").transform;
    }

    public FireAttack(IAttacker _attacker, int bonusDamage) : base(_attacker)
    {
        this.fireDamage = bonusDamage;
    }

    protected override void Modify()
    {
        _attacker.AddDamage(fireDamage, "Fuego");
    }

    /*
    private void Update()
    {
        MoveToTarget();
    }

   public void MoveToTarget()
    {        
        /* float step = speed * Time.deltaTime;
         transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        */
    //}
  
}
