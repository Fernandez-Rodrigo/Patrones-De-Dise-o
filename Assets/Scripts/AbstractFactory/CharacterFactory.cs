using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterFactory
{

    private readonly HeroSpawnerFactory heroFactory;
    private readonly WeaponFactory weaponFactory;

    public CharacterFactory(HeroSpawnerFactory _heroFactory, WeaponFactory _weaponFactory)
    {
        this.heroFactory = _heroFactory;
        this.weaponFactory = _weaponFactory;
    }


    public Hero CreateHero(string heroId)
    {
        return heroFactory.Create(heroId);
    }

    public Weapon CreateWeapon(string weaponId)
    {
        return weaponFactory.Create(weaponId);
    }

}
