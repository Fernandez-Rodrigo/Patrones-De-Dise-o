using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetEnemy : MonoBehaviour
{
    

    public void DamageRecieve(int damage, string elementAttack)
    {
        Debug.Log("Daño recibido: " + damage);
        Debug.Log("Tipo de ataque recibido: " + elementAttack);
    }

}
