using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    [SerializeField] private ZombieSpawnerFactory _zombieSpawnFactory;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
             _zombieSpawnFactory.Create("Zombie", GeneratePosition()); 
        }else if (Input.GetKeyDown(KeyCode.R))
        {
            _zombieSpawnFactory.Create("Red", GeneratePosition());
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
           _zombieSpawnFactory.Create("Green", GeneratePosition());
        }
    }

    private Vector3 GeneratePosition()
    {
        int posX = Random.Range(100, 900);
        int posZ = Random.Range(20, 280);


        Vector3 newPosition = new Vector3(posX, 10, posZ);
        
        return newPosition;
    }

}
