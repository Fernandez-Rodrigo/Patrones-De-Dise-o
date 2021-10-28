using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Configuracion : MonoBehaviour
{
    [SerializeField] Heroe _hero;
    [SerializeField] Espada _sword;
    [SerializeField] Baculo _staff;
    [SerializeField] Lanza _spear;
    public int weaponValue;
    GameObject actualWeapon;

    private void Awake()
    {

        var weapon = InstantiateWeapon(_hero.weaponPlace, weaponValue);
        _hero.SetWeapon(weapon);
     
    }

    private IArma InstantiateWeapon(Transform place, int option)
    {
        switch (option)
        {
            case 1:
                var sword = Instantiate(_sword, place);
                actualWeapon = sword.gameObject;
                return sword;
            case 2:
                var spear = Instantiate(_spear, place);
                actualWeapon = spear.gameObject;
                return spear; 
            case 3:
                var staff = Instantiate(_staff, place);
                actualWeapon = staff.gameObject;
                return staff;
            default:
                return null;
        }

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            weaponValue = 1;
            Destroy(actualWeapon);
            var weapon = InstantiateWeapon(_hero.weaponPlace, weaponValue);
            _hero.SetWeapon(weapon);
            
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            weaponValue = 2;
            Destroy(actualWeapon);
            var weapon = InstantiateWeapon(_hero.weaponPlace, weaponValue);
            _hero.SetWeapon(weapon);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            weaponValue = 3;
            Destroy(actualWeapon);
            var weapon = InstantiateWeapon(_hero.weaponPlace, weaponValue);
            _hero.SetWeapon(weapon);
        }
    }

}
