using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class Heroe : MonoBehaviour, IHeroe
{
    IArma _arma;
    [SerializeField] public Transform weaponPlace;
    [SerializeField] Animator anim;

    public ReactiveProperty<int> Health { get; }

    public Heroe()
    {
        Health = new IntReactiveProperty(1000);
    }


    public void ApplyDamage(int damage)
    {
        Health.Value -= damage;
    }

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
