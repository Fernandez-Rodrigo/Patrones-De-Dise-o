using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(menuName = "Weapon Configuration")]
public class WeaponConfig : ScriptableObject
{
    [SerializeField] private Weapon[] weapons;
    private Dictionary<string, Weapon> idToWeapon;

    private void Awake()
    {
        idToWeapon = new Dictionary<string, Weapon>();

        foreach (var weapon in weapons)
        {
            idToWeapon.Add(weapon.Id, weapon);
        }
    }

    public Weapon GetWeapongPrefabById(string id)
    {
        if (!idToWeapon.TryGetValue(id, out var weapon))
        {
            throw new Exception("No weapon with this ID");
        }

        return weapon;
    }
}
