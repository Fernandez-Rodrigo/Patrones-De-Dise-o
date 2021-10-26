using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFire : MonoBehaviour
{
    [SerializeField] private RegulaAttack fire;
    [SerializeField] private RegulaAttack water;
    [SerializeField] private RegulaAttack normalAttack;
    [SerializeField] private Transform startPosition;
    [SerializeField] private Transform targetPosition;


    public void SpawnRegular(RegulaAttack _attacker, Transform startPosition, Transform _endTarget)
    {
        Instantiate(_attacker, startPosition);
        _endTarget = targetPosition;
    }

    public void SpawnSpecial(RegulaAttack _attacker, Transform startPosition, Transform _endTarget)
    {
        Instantiate(_attacker.gameObject, startPosition);
       
        _endTarget = targetPosition;
    }

    private void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.A))
        {
            SpawnRegular(normalAttack, startPosition, targetPosition);
                                 
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            SpawnSpecial(fire, startPosition, targetPosition);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            SpawnSpecial(water, startPosition, targetPosition);
        }
    }


}
