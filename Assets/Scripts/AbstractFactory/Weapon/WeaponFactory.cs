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
        int posX = Random.Range(100, 900);
        int posZ = Random.Range(25, 280);
        Vector3 position = new Vector3(posX, 5, posZ);
        return Object.Instantiate(weapon, position, Quaternion.Euler(-90f,0f,0f));
    }
}
