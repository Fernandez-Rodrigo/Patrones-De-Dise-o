using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heroe : MonoBehaviour
{
    IArma _arma;
    [SerializeField] public Transform weaponPlace;
    [SerializeField] Animator anim;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetTrigger("Atacar");
            _arma.Attack();
           
        }
    }


    public void SetWeapon(IArma arma)
    {
      _arma = arma;
    }
}
