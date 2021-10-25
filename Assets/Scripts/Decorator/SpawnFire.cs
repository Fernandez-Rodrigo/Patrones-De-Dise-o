using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFire : MonoBehaviour
{
    [SerializeField] private FireAttack normalFire;
   
    [SerializeField] private Transform startPosition;
    [SerializeField] private Transform targetPosition;

    private void Start()
    {

    }

    public void Spawn()
    {
       
        normalFire.Spawn(startPosition);
        normalFire.target = targetPosition;

    }


    private void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.A))
        {
            Spawn();
        }
        
    }




}
