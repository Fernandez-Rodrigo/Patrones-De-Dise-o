using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponFactory
{
    private readonly WeaponConfig weapConfig;

    public WeaponFactory(WeaponConfig weaponConfiguration)
    {
        this.weapConfig = weaponConfiguration;
    }

    public Weapon Create(string id)
    {
        var weapon = weapConfig.GetWeapongPrefabById(id);
        Vector3 position = weapon.Position.transform.position;
        return Object.Instantiate(weapon, position, Quaternion.identity);
    }
}
