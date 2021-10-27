using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espada : MonoBehaviour, IArma
{
    [SerializeField] Animator animator;
    
    public void Attack()
    {
        Debug.Log("Atacaste con un Hacha!");
    }

}
