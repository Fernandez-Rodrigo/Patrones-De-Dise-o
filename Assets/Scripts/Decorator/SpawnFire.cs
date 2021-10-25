using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFire : MonoBehaviour
{
    [SerializeField] private FireAttack normalFire;
   
    [SerializeField] private Transform startPosition;
    [SerializeField] private Transform targetPosition;

   

    public void Spawn(AttackDecorator _attacker, Transform startPosition, Transform _endTarget)
    {
        Instantiate(_attacker, startPosition);
        _endTarget = targetPosition;
    }

    private void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.A))
        {
            Spawn(normalFire, startPosition, targetPosition);
        }
        
    }




}
