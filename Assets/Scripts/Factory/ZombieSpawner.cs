using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
  
    [SerializeField] private SpawnFacade spawnFacade;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            spawnFacade.SpawnZombie();
        }else if (Input.GetKeyDown(KeyCode.R))
        {
            spawnFacade.SpawnRedZombie();
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            spawnFacade.SpawnGreenZombie();
        }
    }



}
