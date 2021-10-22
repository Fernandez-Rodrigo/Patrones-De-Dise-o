using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SettingsMenu : MonoBehaviour
{
    [SerializeField] private Button _back;
    [SerializeField] private GameObject _canvasGroup;

    MediatorMenu _mediator;

    private void Awake()
    {
        _back.onClick.AddListener(() => _mediator.GoToMainMenu());
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
