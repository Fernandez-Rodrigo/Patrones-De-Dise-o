using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baculo : MonoBehaviour, IArma
{
    [SerializeField] Animator animator;
    public void Attack()
    {
        Debug.Log("Lanzaste un hechizo con el Baculo!");
    }
}
