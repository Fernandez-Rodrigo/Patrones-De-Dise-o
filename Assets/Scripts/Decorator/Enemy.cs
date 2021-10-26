using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, ITargetEnemy
{

    public void DamageRecieved(int damage, string elementAttack)
    {
        Debug.Log("Se recibió daño por: " + damage);
        Debug.Log("El daño es de tipo: " + elementAttack);
    }


    private void OnTriggerEnter(Collider other)
    {
        RegulaAttack regular = other.GetComponent<RegulaAttack>();
        
        if (regular)
        {
            regular.MakeDamage(this);

            Destroy(regular.gameObject);

        }

       
    }
}
