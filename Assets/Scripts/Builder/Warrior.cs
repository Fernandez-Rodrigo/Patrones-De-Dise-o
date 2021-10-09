using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : MonoBehaviour
{
    private Dictionary<PartsPosition, Clothes> _setConfig;
    private Gender _gender;


    public void SetComponents(Dictionary<PartsPosition, Clothes> _set, Gender gender)
    {
        _setConfig = _set;
        _gender = gender;
    }
}
