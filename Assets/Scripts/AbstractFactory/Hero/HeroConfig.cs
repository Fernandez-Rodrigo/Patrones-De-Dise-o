using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
[CreateAssetMenu(menuName = "Heroes Configuration")]
public class HeroConfig : ScriptableObject
{

    [SerializeField] private Hero[] heroes;
    private Dictionary<string, Hero> idToHero;

    private void Awake()
    {
        idToHero = new Dictionary<string, Hero>();

        foreach (var hero in heroes)
        {
            idToHero.Add(hero.Id, hero);
        }
    }

    public Hero GetHeroPrefabById(string id)
    {
        if (!idToHero.TryGetValue(id, out var hero))
        {
            throw new Exception("No hero with this ID");
        }

        return hero;
    }
}