using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegulaAttack : MonoBehaviour, IAttacker
{

    private List<AttackDecorator> decorators = new List<AttackDecorator>();
    float speed = 90f;
    Transform target;
    private int damage = 20;


    private void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Finish").transform;
    }

    private void Start()
    {
       ModifiersDecorators(new FireAttack(this, 50));
    }

    public void ModifiersDecorators(AttackDecorator newDecorators)
    {
        decorators.Add(newDecorators);
    }

    public void MakeDamage(ITargetEnemy targetEnemy)
    {
        for(int i = 0; i <decorators.Count; i++)
        {
            decorators[i].MakeDamage(targetEnemy);

        }

        targetEnemy.DamageRecieved(damage, "Normal");
    }

    public void AddDamage(int bonusDamage, string type)
    {
        damage += bonusDamage;
        
    }



    
    private void Update()
    {
        MoveToTarget();
    }


    public void MoveToTarget()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }

  
    

}
