using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lanza : MonoBehaviour, IArma
{
    [SerializeField] Animator animator;
    public void Attack()
    {
        Debug.Log("Blandiste la Lanza!");
    }
}
