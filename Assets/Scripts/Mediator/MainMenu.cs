using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button _selectPattern;
    [SerializeField] private Button _settings;
    [SerializeField] private GameObject _canvasGroup;

    MediatorMenu _mediator;


    private void Awake()
    {
        _selectPattern.onClick.AddListener(() => _mediator.ShowPatterns());
        _settings.onClick.AddListener(() => _mediator.ShowSettings());
    }


    public void Configure(MediatorMenu mediator)
    {
        _mediator = mediator;
    }

    public void Show()
    {

        _canvasGroup.SetActive(true);
    }

    public void Hide()
    {

        _canvasGroup.SetActive(false);
    }

}
