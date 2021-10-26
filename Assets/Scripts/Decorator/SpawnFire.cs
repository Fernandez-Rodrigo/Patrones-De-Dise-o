using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFire : MonoBehaviour
{
    [SerializeField] private FireAttack normalFire;
    [SerializeField] private RegulaAttack normalAttack;


    [SerializeField] private Transform startPosition;
    [SerializeField] private Transform targetPosition;

   

    public void SpawnRegular(RegulaAttack _attacker, Transform startPosition, Transform _endTarget)
    {
        Instantiate(_attacker, startPosition);
        _endTarget = targetPosition;
    }

    public void SpawnSpecial(AttackDecorator _attacker, RegulaAttack _regularAttack, Transform startPosition, Transform _endTarget)
    {
        //Instantiate(_attacker, startPosition);
        Instantiate(_regularAttack, startPosition);
        _endTarget = targetPosition;
    }

    private void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.A))
        {
            SpawnRegular(normalAttack, startPosition, targetPosition);
                                 
        }

       
    }




}
