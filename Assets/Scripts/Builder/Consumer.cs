using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumer : MonoBehaviour
{

    private void Awake()
    {
        new WarriorBuilder()
            .WithGender(null)
            .WithSet(PartsPosition.Weapon, null)
            .Build();
    }
}
