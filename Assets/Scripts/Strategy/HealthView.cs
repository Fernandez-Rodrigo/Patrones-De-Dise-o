using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class HealthView : MonoBehaviour
{
    [SerializeField] private Text _health;

    public void Configure(IHeroe _hero)
    {
        _hero.Health.Subscribe(Updated);
    }

    private void Updated(int health)
    {
        _health.text = health.ToString();
    
    }
}
