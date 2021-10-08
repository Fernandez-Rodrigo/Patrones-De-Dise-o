using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ZombieSpawnerFactory : MonoBehaviour
{
    [SerializeField] private Zombie[] _zombies;

    private Dictionary<string, Zombie> _idToZombie;

    private void Awake()
    {
        _idToZombie = new Dictionary<string, Zombie>();
        foreach(var zombie in _zombies)
        {
            _idToZombie.Add(zombie.Id, zombie);
        }
    }

    public Zombie Create(string id, Vector3 spawnPosition) 
    {
        if(!_idToZombie.TryGetValue(id, out var zombie))
        {
            throw new Exception("No existe");
        }
      

        return Instantiate(zombie, spawnPosition, Quaternion.identity);
    }
}
