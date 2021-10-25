using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAttack : AttackDecorator
{
    float speed = 90f;
    Transform target;
    TargetEnemy targetEnemy;
 
    private readonly int fireDamage = 50;

    private void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Finish").transform;
    }

  
    public FireAttack (IAttacker attacker, int _fireDamage) : base(attacker)
    {
        fireDamage = _fireDamage;
    }

    private void Update()
    {
        MoveToTareget();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Target")
        {
            
            Destroy(this.gameObject);
        }
    }


    public override void MakeDamage(TargetEnemy targetEnemy) 
    {
        base.MakeDamage(targetEnemy);
        targetEnemy.DamageRecieve(fireDamage, "Fuego");
    }
        

    public void MoveToTareget()
    {        
         float step = speed * Time.deltaTime;
         transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }

}
