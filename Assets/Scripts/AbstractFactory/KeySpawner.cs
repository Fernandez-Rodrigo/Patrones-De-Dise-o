using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySpawner : MonoBehaviour
{
    [SerializeField] private SpawnFacade spawnFacade;

   
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            spawnFacade.SpawnMale();
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            spawnFacade.SpawnFemale();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            spawnFacade.SpawnSword1();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            spawnFacade.SpawnSword2();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            spawnFacade.SpawnSword3();
        }

      
    }
}
