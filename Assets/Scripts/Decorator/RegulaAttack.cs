using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegulaAttack : MonoBehaviour, IAttacker
{

    private List<AttackDecorator> decorators = new List<AttackDecorator>();
    public RegulaAttack regularAttack;
    float speed = 90f;
    Transform target;
    private int damage = 20;
    string type = "Normal";

    public List<AttackDecorator> Decorators { get => decorators; set => decorators = value; }

    private void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Finish").transform;
    }

    private void Start()
    {
        
        if (this.gameObject.tag == "Fire")
        {
            ModifiersDecorators(new FireAttack(this, 50));
        }

        if (this.gameObject.tag == "Water")
        {
            ModifiersDecorators(new WatterAttack(this, 40));
        }
    }

    public void ModifiersDecorators(AttackDecorator newDecorators)
    {
        Decorators.Add(newDecorators);
    }

    public void MakeDamage(ITargetEnemy targetEnemy)
    {
        for(int i = 0; i <Decorators.Count; i++)
        {
            Decorators[i].MakeDamage(targetEnemy);

        }

        targetEnemy.DamageRecieved(damage, type);
    }

    public void AddDamage(int bonusDamage, string _type)
    {
        damage += bonusDamage;
        type = _type;
        
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
