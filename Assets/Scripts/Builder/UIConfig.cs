using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIConfig : MonoBehaviour
{
    [SerializeField] private Gender _gender1;
    [SerializeField] private Gender _gender2;

    [SerializeField] private Clothes _set1;
    [SerializeField] private Clothes _set2;

    [SerializeField] private Warrior _warrior;

    [SerializeField] private Button gender1Btn;
    [SerializeField] private Button gender2Btn;

    [SerializeField] private Button set1Btn;
    [SerializeField] private Button set2Btn;

    [SerializeField] private Button buildBtn;

    private WarriorBuilder _warriorBuilder;
    private Warrior instanceWarrior;

    private void Awake()
    {
        _warriorBuilder = new WarriorBuilder();
        _warriorBuilder.FromPrefab(_warrior);

        gender1Btn.onClick.AddListener(Gender1Pressed);
        gender2Btn.onClick.AddListener(Gender2Pressed);

        set1Btn.onClick.AddListener(Set1Pressed);
        set2Btn.onClick.AddListener(Set2Pressed);

        buildBtn.onClick.AddListener(BuildPressed);
    }

    private void BuildPressed()
    {
        if(instanceWarrior != null)
        {
            Destroy(instanceWarrior.gameObject);
        }
       instanceWarrior = _warriorBuilder.Build();
    }

    private void Set2Pressed()
    {
       
        _warriorBuilder.WithSet(PartsPosition.Weapon, _set2);
       
    }

    private void Set1Pressed()
    {
       
        _warriorBuilder.WithSet(PartsPosition.Weapon, _set1);
      
    }

    private void Gender2Pressed()
    {
        _warriorBuilder.WithGender(_gender2);
    }

    private void Gender1Pressed()
    {
        _warriorBuilder.WithGender(_gender1);
    }
}
