using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorBuilder 
{
    private Gender _gender;
    private Dictionary<PartsPosition, Clothes> _clothes = new Dictionary<PartsPosition, Clothes>();
    private Vector3 charPosition = new Vector3 (1073.9f, 21.7f, 151.6f);
    // private Quaternion _rotation;
    private Warrior _warrior;


    public WarriorBuilder WithGender(Gender gender)
    {
        _gender = gender;
        return this;
    }

    public WarriorBuilder WithSet(PartsPosition position, Clothes clothes)
    {
        if (_clothes.ContainsKey(position))
        {
            _clothes.Remove(position);
        }
        _clothes.Add(position, clothes);
        return this;
    }

    public WarriorBuilder Position(Vector3 charPos)
    {
        charPosition = charPos;
        return this;
    }

    public WarriorBuilder FromPrefab(Warrior warrior)
    {
        _warrior = warrior;
        return this;
    }

    public Warrior Build()
    {
        var warrior = Object.Instantiate(_warrior, charPosition, Quaternion.Euler(0f,180f,0f));
        var gender = Object.Instantiate(_gender, warrior.transform, true);
        var set = new Dictionary<PartsPosition, Clothes>();

        foreach(var part in _clothes)
        {
            var clothInstance = Object.Instantiate(part.Value, gender.GetSetPosition(part.Key));
            set.Add(part.Key, clothInstance);
        }

        warrior.SetComponents(set, gender);

        return warrior;
    }

}
