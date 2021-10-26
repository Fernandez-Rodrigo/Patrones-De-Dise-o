using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFire : MonoBehaviour
{
    [SerializeField] private RegulaAttack normalFire;
    [SerializeField] private RegulaAttack normalAttack;
    private FireAttack fire;


    [SerializeField] private Transform startPosition;
    [SerializeField] private Transform targetPosition;


    private void Awake()
    {
        normalFire = new RegulaAttack();
        fire = new FireAttack(normalFire, 50);
    }

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
            AddSpecial(fire);
            SpawnSpecial(normalFire, startPosition, targetPosition);
        }


    }


    public void AddSpecial(AttackDecorator addSpecial)
    {
        normalFire.ModifiersDecorators(addSpecial);
    }



}
