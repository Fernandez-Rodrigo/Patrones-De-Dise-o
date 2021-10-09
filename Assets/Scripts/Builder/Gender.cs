using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class Gender : MonoBehaviour
{
   
    [SerializeField]
    private Transform _weapon;
   

    public Transform GetSetPosition(PartsPosition position)
    {
        switch (position)
        {
            
            case PartsPosition.Weapon:
                return _weapon;
        }

        throw new ArgumentOutOfRangeException("No existe parte");
    }

}
