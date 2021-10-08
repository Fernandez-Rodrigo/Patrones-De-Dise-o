using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HeroSpawnerFactory
{
    private readonly HeroConfig heroConfiguration;

     public HeroSpawnerFactory(HeroConfig heroConfig)
    {
        this.heroConfiguration = heroConfig;
    }

    public Hero Create(string id)
    {
        var hero = heroConfiguration.GetHeroPrefabById(id);
        int posX = Random.Range(100, 900);
        int posZ = Random.Range(25, 280);
       Vector3 position = new Vector3(posX, 0, posZ);

        return Object.Instantiate(hero, position, Quaternion.identity);
    }
}
