using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] private string _id;
    [SerializeField] private GameObject position;
    public string Id => _id;
    public GameObject Position => position;
}
