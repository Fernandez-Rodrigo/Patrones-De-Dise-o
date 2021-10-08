using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySpawner : MonoBehaviour
{
    private CharacterFactory currentCharacFactory;

    public void Configure(CharacterFactory _characterFactory)
    {
        currentCharacFactory = _characterFactory;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            currentCharacFactory.CreateHero("Male");
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            currentCharacFactory.CreateHero("Female");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            currentCharacFactory.CreateWeapon("Sword1");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            currentCharacFactory.CreateWeapon("Sword2");
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            currentCharacFactory.CreateWeapon("Sword3");
        }

      
    }
}
